using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLK.Model
{
    public class TipoProcesso
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public override string ToString()
        {
            return Nome;
        }

    }
}
