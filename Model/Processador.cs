using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLK.Model
{
    public class Processador
    {
        public string Name { get; set; }
        public int QtdCores{ get; set; }
        public List<Core> Cores { get; set; }

        public Processador()
        {
            this.Name = GetNameProcessor();
            this.QtdCores = GetCoresProcessor();
            this.Cores = DefineCoreProcessors(QtdCores);
        }

        public static string GetSystemComponent(string hwclass, string syntax)
        {
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mo in managementObjectSearcher.Get())
            {
                return Convert.ToString(mo[syntax]);
            }

            return "NaN";
        }

        public string GetNameProcessor()
        {
            return GetSystemComponent("Win32_Processor", "Name").ToString();

        }

        public int GetCoresProcessor()
        {
            return Convert.ToInt32(GetSystemComponent("Win32_Processor", "NumberOfCores"));
        }
        public List<Core> DefineCoreProcessors(int coresNumber)
        {
            List<Core> cores = new List<Core>();
            for (int i = 0; i < coresNumber; i++)
            {
                cores.Add(new Core(i + 1, new List<Processo>()));
            }
            return cores;
        }


    }
}
