using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerLK.Model
{
    public class Processo
    {
        public int Pid { get; set; }
        public int Prioridade { get; set; }

        public int TempoUCP { get; set; }
        public int RunningNumeCycles { get; set; }


        public TipoProcesso TipoProcesso { get; set; }
        public string Estado { get; set; }
        public bool ProcessIsIO { get; set; }

        public int TimeIoSleep { get; set; }
        public string Agora { get; set; }


        public Processo(int pid, int prioridade, int TempoUcp, TipoProcesso TipoProcesso, string Estado, string Agora)
        {
            this.Pid = pid;
            this.Prioridade = prioridade;
            this.TempoUCP = TempoUcp;
            this.TipoProcesso = TipoProcesso;
            this.RunningNumeCycles = TempoUcp;
            this.Estado = Estado;
            this.Agora = Agora;
            if (this.TipoProcesso.Nome.Equals("I/O Bound"))
            {
                this.ProcessIsIO = true;
                this.TimeIoSleep = 10;
            }
            else
            {
                this.ProcessIsIO = false;
            }
        }




        public async Task<bool> ExecuteCicle()
        {

            if (this.RunningNumeCycles <= 0 && (this.Estado == "Executando 🔄" || this.Estado == "Pronto ✔" || this.Estado == "Em Espera 🅿️"))
            {

                this.RunningNumeCycles = 0;
                this.Estado = "Finalizado ❎";
                this.Agora = "Nda";


                return true;
            }
            else if (this.RunningNumeCycles > 0 && (this.Estado == "Executando 🔄" || this.Estado == "Pronto ✔" || this.Estado == "Em Espera 🅿️"))
            {


                if (this.ProcessIsIO)
                {
                    if (this.TimeIoSleep == 0)
                    {
                        this.RunningNumeCycles--;
                        this.Estado = "Executando 🔄";
                        this.Agora = "Processando";
                        this.TimeIoSleep = 10;
                        return false;
                    }
                    else
                    {
                        this.Estado = "Em Espera 🅿️";
                        TimeIoSleep--;
                        this.Agora = "I/O";

                        return false;
                    }
                }
                else
                {
                    this.RunningNumeCycles--;
                    this.Estado = "Executando 🔄";
                    this.Agora = "Processando";

                    return false;
                }



            }

            return false;
        }

        public async Task<int> SleepIO()
        {
            if (this.TimeIoSleep > 0 && this.TimeIoSleep <= 10)
            {
                TimeIoSleep--;
                this.Agora = "I/O";
                return 1;
            }
            return 0;

        }
    }
}
