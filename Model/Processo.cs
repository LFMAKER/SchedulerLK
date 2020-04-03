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
        public Processo(int pid, int prioridade, int TempoUcp, TipoProcesso TipoProcesso, string Estado)
        {
            this.Pid = pid;
            this.Prioridade = prioridade;
            this.TempoUCP = TempoUcp;
            this.TipoProcesso = TipoProcesso;
            this.RunningNumeCycles = TempoUcp;
            this.Estado = Estado;
        }




        public async Task<bool> ExecuteCicle()
        {
            if (this.RunningNumeCycles <= 0 && this.Estado == "Executando 🔄")
            {
                this.RunningNumeCycles = 0;
                this.Estado = "Finalizado ❎";

              
                return true;
            }
            else if (this.RunningNumeCycles > 0 && this.Estado == "Executando 🔄" || this.Estado == "Pronto ✔")
            {
                this.RunningNumeCycles--;
                this.Estado = "Executando 🔄";

                return false;
            }

            return false;
        }


    }
}
