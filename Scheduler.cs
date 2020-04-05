using SchedulerLK.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SchedulerLK
{
    public partial class Scheduler : Form
    {
        //Moving
        int mov;
        int movX;
        int movY;

        #region InitializeProcessor
        Processador processadorGlobal;
        CoreEspera coreEspera;

        #endregion InitializeProcessor

        public Scheduler()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = false;
        }

        #region Load
        private void Scheduler_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;

            //Tipos de Processo
            List<TipoProcesso> tp = new List<TipoProcesso>();
            tp.Add(new TipoProcesso() { Id = 0, Nome = "CPU Bound" });
            tp.Add(new TipoProcesso() { Id = 1, Nome = "I/O Bound" });

            TipoProcesso.DisplayMember = "Nome";
            TipoProcesso.ValueMember = "Id";
            TipoProcesso.DataSource = tp;
            TipoProcesso.SelectedIndex = 0;

            TempoUCP.Text = "1";

            //Alocando Processador
            processadorGlobal = new Processador();

            //Alocando um core de espera
            coreEspera = new CoreEspera();
            coreEspera.ProcessosEspera = new List<Processo>();


            backgroundWorker1.RunWorkerAsync();
        }
        #endregion Load

        #region Click
        private void btnCriarProcesso_Click_1(object sender, EventArgs e)
        {

            Random numAleatorio = new Random();
            int PID = numAleatorio.Next(1, 1000);

            DataTable ss = new DataTable();
            ss.Columns.Add("PID");
            ss.Columns.Add("Prioridade");
            ss.Columns.Add("Estado");
            ss.Columns.Add("Tempo UCP");
            ss.Columns.Add("Tipo Processo");
            ss.Columns.Add("Agora");

            //Criando o Processo e alocando
            Processo processo = new Processo(
                PID, SliderPrioridade.Value,
                Convert.ToInt32(TempoUCP.Text),
                new Model.TipoProcesso()
                {
                    Id = Convert.ToInt32(TipoProcesso.SelectedValue),
                    Nome = TipoProcesso.SelectedItem.ToString()
                },
                "Pronto ✔", "Alocando Core");
            (int, int, string) CoreAllocated = Core.CoreSelector(processadorGlobal.Cores, processo, coreEspera);

            //Adiciona o processo no grid do core responsável
            DefineCoreGrid(CoreAllocated);

            DataRow row = ss.NewRow();
            row["PID"] = processo.Pid;
            row["Prioridade"] = processo.Prioridade;
            row["Estado"] = processo.Estado;
            row["Tempo UCP"] = processo.TempoUCP;
            row["Tipo Processo"] = processo.TipoProcesso.Nome;
            row["Agora"] = processo.Agora;


            ss.Rows.Add(row);

            foreach (DataRow Drow in ss.Rows)
            {
                int num = GridProcessos.Rows.Add();
                GridProcessos.Rows[num].Cells[0].Value = Drow["PID"].ToString();
                GridProcessos.Rows[num].Cells[1].Value = Drow["Prioridade"].ToString();
                GridProcessos.Rows[num].Cells[2].Value = Drow["Estado"].ToString();
                GridProcessos.Rows[num].Cells[3].Value = Drow["Tempo UCP"].ToString();
                GridProcessos.Rows[num].Cells[4].Value = Drow["Tipo Processo"].ToString();
                GridProcessos.Rows[num].Cells[5].Value = Drow["Agora"].ToString();


            }




        }
        #endregion Click

        #region BackgroundWorker
        // Set up the BackgroundWorker object by 
        // attaching event handlers. 
        private void InitializeBackgroundWorker()
        {

            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundWorker1_ProgressChanged);




        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
         {

            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.

            e.Result = ExecutarProcessamento(worker, e);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private async Task<object> ExecutarProcessamento(BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                Processador processadorReserva = new Processador();
                processadorReserva.Cores = processadorGlobal.Cores;

                ProcessTx(1);
                foreach (Core core in processadorReserva.Cores)
                {
                    foreach (Processo processw in core.Processos)
                    {
                        //Verificar se não existe um processo com maior prioridade aguardando ou em execução
                        if (!processw.Estado.Equals("Finalizado ❎"))
                        {
                            //Thread.Sleep(1000);

                            bool TemMaior = processadorGlobal.Cores[core.IdCore - 1].Processos.Any(x => x.Prioridade > processw.Prioridade && !x.Estado.Equals("Finalizado ❎"));
                            bool TemExecutandoNoCore = processadorGlobal.Cores[core.IdCore - 1].Processos.Any(x => x.Estado.Equals("Executando 🔄") && x.Prioridade == processw.Prioridade && !x.Pid.Equals(processw.Pid));

                            if (!TemMaior && !TemExecutandoNoCore)
                            {

                                bool finalizou = await processw.ExecuteCicle();

                                //Atualiza o status na Grid de Processos
                                AtualizarGridProcessos(processw);

                                //Atualiza o status do processo da Grid Core responsável
                                AtualizarGridCores(processw, core.IdCore);

                                if (finalizou)
                                {
                                    //Remover finalizado do core e grid core
                                    RemoverProcessoCore(processw, core.IdCore);
                                }


                            }
                            else
                            {
                                //O Processo deve ser alocado em espera para que um de prioridade maior fique em execução
                                processw.Estado = "Em Espera 🅿️";
                                processw.Agora = "Aguardando";


                                AtualizarGridProcessos(processw);
                                //Atualizar Estado para Em Espera no core em que o processo se encontra.
                                AtualizarGridCores(processw, core.IdCore);
                            }

                        }
                    }
                }

                List<Processo> ProcessosRemoverEspera = new List<Processo>();
                CoreEspera coreEsperaReserva = new CoreEspera();
                coreEsperaReserva = coreEspera;

                //Alocando processos em espera para um core disponível
                foreach (Processo processo in coreEsperaReserva.ProcessosEspera)
                {
                    (int, int, string) CoreAllocated = Core.CoreSelector(processadorGlobal.Cores, processo, coreEspera);
                    if (CoreAllocated.Item1 != 0)
                    {
                        //Adiciona o processo no grid do core responsável
                        DefineCoreGrid(CoreAllocated);




                        coreEspera.ProcessosEspera.Remove(processo);
                    }

                }



                return true;

            }
            return false;
        }

        public void ProcessTx(int value)
        {
            if (InvokeRequired)
            {
                try
                {
                    this.Invoke(new Action<int>(ProcessTx), new object[] { value });
                }
                catch (Exception ex)
                {
                    return;
                }
                return;
            }
            if(ProgressTx.Value == ProgressTx.MaximumValue)
            {
                ProgressTx.Value = 0;
            }
            ProgressTx.Value += value;
        }
        #endregion BackgroundWorker

        #region Changed
        private void TipoProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion Changed


        public void DefineCoreGrid((int, int, string) coreAllocated)
        {

            DataTable ss = new DataTable();
            ss.Columns.Add("PID");
            ss.Columns.Add("Estado");

            DataRow row = ss.NewRow();
            row["PID"] = coreAllocated.Item2;
            row["Estado"] = coreAllocated.Item3;

            ss.Rows.Add(row);

            foreach (DataRow Drow in ss.Rows)
            {
                switch (coreAllocated.Item1)
                {
                    case 1:
                        int num = GridCore1.Rows.Add();
                        GridCore1.Rows[num].Cells[0].Value = Drow["PID"].ToString();
                        GridCore1.Rows[num].Cells[1].Value = Drow["Estado"].ToString();
                        break;
                    case 2:
                        int num2 = GridCore2.Rows.Add();
                        GridCore2.Rows[num2].Cells[0].Value = Drow["PID"].ToString();
                        GridCore2.Rows[num2].Cells[1].Value = Drow["Estado"].ToString();
                        break;
                    case 3:
                        int num3 = GridCore3.Rows.Add();
                        GridCore3.Rows[num3].Cells[0].Value = Drow["PID"].ToString();
                        GridCore3.Rows[num3].Cells[1].Value = Drow["Estado"].ToString();
                        break;
                    case 4:
                        int num4 = GridCore4.Rows.Add();
                        GridCore4.Rows[num4].Cells[0].Value = Drow["PID"].ToString();
                        GridCore4.Rows[num4].Cells[1].Value = Drow["Estado"].ToString();
                        break;
                }

            }


        }

        public void AtualizarGridCores(Processo processw, int core)
        {
            switch (core)
            {
                case 1:
                    foreach (DataGridViewRow row in GridCore1.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string pid = row.Cells[0].Value.ToString();
                            if (pid.Equals(processw.Pid.ToString()))
                            {
                                GridCore1.Rows[row.Index].Cells[1].Value = processw.Estado;

                            }
                        }
                    }
                    break;

                case 2:
                    foreach (DataGridViewRow row in GridCore2.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string pid = row.Cells[0].Value.ToString();
                            if (pid.Equals(processw.Pid.ToString()))
                            {
                                GridCore2.Rows[row.Index].Cells[1].Value = processw.Estado;

                            }
                        }
                    }
                    break;

                case 3:
                    foreach (DataGridViewRow row in GridCore3.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string pid = row.Cells[0].Value.ToString();
                            if (pid.Equals(processw.Pid.ToString()))
                            {
                                GridCore3.Rows[row.Index].Cells[1].Value = processw.Estado;

                            }
                        }
                    }
                    break;

                case 4:
                    foreach (DataGridViewRow row in GridCore4.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string pid = row.Cells[0].Value.ToString();
                            if (pid.Equals(processw.Pid.ToString()))
                            {
                                GridCore4.Rows[row.Index].Cells[1].Value = processw.Estado;

                            }
                        }
                    }
                    break;
            }
        }
        public void AtualizarGridProcessos(Processo processo)
        {
            foreach (DataGridViewRow row in GridProcessos.Rows)
            {

                if (row.Cells[0].Value != null)
                {
                    string pid = row.Cells[0].Value.ToString();
                    if (pid.Equals(processo.Pid.ToString()))
                    {
                        GridProcessos.Rows[row.Index].Cells[2].Value = processo.Estado;
                        GridProcessos.Rows[row.Index].Cells[3].Value = processo.RunningNumeCycles;
                        GridProcessos.Rows[row.Index].Cells[5].Value = processo.Agora;


                    }
                }

            }
        }

        public void RemoverProcessoCore(Processo processw, int core)
        {
            processadorGlobal.Cores[core - 1].Processos.Remove(processw);

            //Removendo do grid core
            switch (core)
            {
                case 1:
                    foreach (DataGridViewRow row in GridCore1.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string pid = row.Cells[0].Value.ToString();
                            if (pid.Equals(processw.Pid.ToString()))
                            {
                                GridCore1.Rows.RemoveAt(row.Index);

                            }
                        }
                    }
                    break;

                case 2:
                    foreach (DataGridViewRow row in GridCore2.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string pid = row.Cells[0].Value.ToString();
                            if (pid.Equals(processw.Pid.ToString()))
                            {
                                GridCore2.Rows.RemoveAt(row.Index);

                            }
                        }
                    }
                    break;

                case 3:
                    foreach (DataGridViewRow row in GridCore3.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string pid = row.Cells[0].Value.ToString();
                            if (pid.Equals(processw.Pid.ToString()))
                            {
                                GridCore3.Rows.RemoveAt(row.Index);

                            }
                        }
                    }
                    break;

                case 4:
                    foreach (DataGridViewRow row in GridCore4.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string pid = row.Cells[0].Value.ToString();
                            if (pid.Equals(processw.Pid.ToString()))
                            {
                                GridCore4.Rows.RemoveAt(row.Index);

                            }
                        }
                    }
                    break;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            LKPagesPrincipal.SetPage(0);
        }

        private void btnProcessador_Click(object sender, EventArgs e)
        {
            LKPagesPrincipal.SetPage(1);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SliderPrioridade_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            lblPrioridadeValor.Text = SliderPrioridade.Value.ToString();
        }

        private void TempoUCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            LKPagesPrincipal.SetPage(2);

        }
    }
}
