using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLK.Model
{
    public class Core
    {
        public Core(int idCore, List<Processo> Processos)
        {
            IdCore = idCore;
            this.Processos = Processos;
        }

        public int IdCore { get; set; }
        public List<Processo> Processos { get; set; }



        public static (int, int, string) CoreSelector(List<Core> coresProcessor, Processo process, CoreEspera coreEspera)
        {
            int alocate = 0;
            int tryAlocate = 0;
            foreach (Core core in coresProcessor)
            {
                if (core.Processos == null || !core.Processos.Any(x => x.Estado.Contains("Pronto ✔") || x.Estado.Contains("Executando 🔄")) /*&& alocate == 0*/)
                {
                        core.Processos.Add(process);
                        alocate++;
                        return (core.IdCore, process.Pid, process.Estado);
                }
                else
                {
                    tryAlocate++;
                    
                }

                if(tryAlocate == coresProcessor.Count)
                {
                    //Adicionar na lista de espera
                    if (!coreEspera.ProcessosEspera.Any(x => x.Pid.Equals(process.Pid)))
                    {
                        coreEspera.ProcessosEspera.Add(process);
                    }
                }
            }

            return (0, 0, "Espera");
        }
        public override string ToString()
        {
            return string.Format("{0} Core - Processes -> {1}", IdCore, Processos.Count);
        }


    }
}
