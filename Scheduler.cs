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
        #region InitializeProcessor
        Processador processadorGlobal;
        CoreEspera coreEspera;

        #endregion InitializeProcessor

        public Scheduler()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = false;
            backgroundWorker1.WorkerSupportsCancellation = false;
        }

        #region Load
        private void Scheduler_Load(object sender, EventArgs e)
        {


            //Tipos de Processo
            List<TipoProcesso> tp = new List<TipoProcesso>();
            tp.Add(new TipoProcesso() { Id = 0, Nome = "CPU Bound" });
            TipoProcesso.DisplayMember = "Nome";
            TipoProcesso.ValueMember = "Id";
            TipoProcesso.DataSource = tp;
            TipoProcesso.SelectedIndex = 0;


            //Alocando Processador
            processadorGlobal = new Processador();

            //Alocando um core de espera
            coreEspera = new CoreEspera();
            coreEspera.ProcessosEspera = new List<Processo>();

            txtProcessorName.Text = processadorGlobal.Name;
            txtQtdProcesorCores.Text = processadorGlobal.QtdCores.ToString();

            backgroundWorker1.RunWorkerAsync();
        }
        #endregion Load

        #region Click
        private void btnCriarProcesso_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int PID = numAleatorio.Next(1, 1000);

            DataTable ss = new DataTable();
            ss.Columns.Add("PID");
            ss.Columns.Add("Prioridade");
            ss.Columns.Add("Estado");
            ss.Columns.Add("Tempo UCP");
            ss.Columns.Add("Tipo Processo");
            //Criando o Processo e alocando
            Processo processo = new Processo(
                PID, Convert.ToInt32(Prioridade.Value),
                Convert.ToInt32(TempoUCP.Value),
                new Model.TipoProcesso()
                {
                    Id = Convert.ToInt32(TipoProcesso.SelectedValue),
                    Nome = TipoProcesso.SelectedItem.ToString()
                },
                "Pronto ✔");
            (int, int, string) CoreAllocated = Core.CoreSelector(processadorGlobal.Cores, processo, coreEspera);

            //Adiciona o processo no grid do core responsável
            DefineCoreGrid(CoreAllocated);

            DataRow row = ss.NewRow();
            row["PID"] = processo.Pid;
            row["Prioridade"] = processo.Prioridade;
            row["Estado"] = processo.Estado;
            row["Tempo UCP"] = processo.TempoUCP;
            row["Tipo Processo"] = processo.TipoProcesso.Nome;

            ss.Rows.Add(row);

            foreach (DataRow Drow in ss.Rows)
            {
                int num = GridProcessos.Rows.Add();
                GridProcessos.Rows[num].Cells[0].Value = Drow["PID"].ToString();
                GridProcessos.Rows[num].Cells[1].Value = Drow["Prioridade"].ToString();
                GridProcessos.Rows[num].Cells[2].Value = Drow["Estado"].ToString();
                GridProcessos.Rows[num].Cells[3].Value = Drow["Tempo UCP"].ToString();
                GridProcessos.Rows[num].Cells[4].Value = Drow["Tipo Processo"].ToString();

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
                
                ProcessTx(GenerateTx());
                foreach (Core core in processadorReserva.Cores)
                {
                    foreach (Processo processw in core.Processos)
                    {
                        if(!processw.Estado.Equals("Finalizado ❎")){
                            //Thread.Sleep(1000);

                            await processw.ExecuteCicle();
                            foreach (DataGridViewRow row in GridProcessos.Rows)
                            {

                                if (row.Cells[0].Value != null)
                                {
                                    string pid = row.Cells[0].Value.ToString();
                                    if (pid.Equals(processw.Pid.ToString()))
                                    {
                                        GridProcessos.Rows[row.Index].Cells[2].Value = processw.Estado;
                                        GridProcessos.Rows[row.Index].Cells[3].Value = processw.RunningNumeCycles;

                                    }
                                }

                            }
                            
                        }
                        

                    }
                }

                List<Processo> ProcessosRemoverEspera = new List<Processo>();
                CoreEspera coreEsperaReserva = new CoreEspera();
                coreEsperaReserva = coreEspera;

                //Alocando processos em espera para um core disponível
                foreach(Processo processo in coreEsperaReserva.ProcessosEspera)
                {
                    (int, int, string) CoreAllocated = Core.CoreSelector(processadorGlobal.Cores, processo, coreEspera);
                    if(CoreAllocated.Item1 != 0)
                    {
                        //Adiciona o processo no grid do core responsável
                        DefineCoreGrid(CoreAllocated);

                        foreach (DataGridViewRow row in GridProcessos.Rows)
                        {

                            if (row.Cells[0].Value != null)
                            {
                                string pid = row.Cells[0].Value.ToString();
                                if (pid.Equals(processo.Pid.ToString()))
                                {
                                    GridProcessos.Rows[row.Index].Cells[2].Value = processo.Estado;
                                    GridProcessos.Rows[row.Index].Cells[3].Value = processo.RunningNumeCycles;

                                }
                            }

                        }


                        coreEspera.ProcessosEspera.Remove(processo);
                    }
                   
                }



                return true;

            }
            return false;
        }

        public void ProcessTx(string value)
        {
            if (InvokeRequired)
            {
                try
                {
                    this.Invoke(new Action<string>(ProcessTx), new object[] { value });
                }
                catch (Exception ex)
                {
                    return;
                }
                return;
            }
            txtProcessTx.Clear();
            txtProcessTx.Text = value;
        }
        #endregion BackgroundWorker

        #region Changed
        private void TipoProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion Changed


        #region Generate
        public string GenerateTx()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }
        #endregion


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
    }
}
