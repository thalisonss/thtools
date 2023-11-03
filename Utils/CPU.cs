using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThTools.Utils
{
    internal class CPU
    {
        #region | Variaveis |
        PerformanceCounter cpuCounter;
        int porcentagemCPU = 0;
        string porcentagemCPUStr = string.Empty;
        #endregion

        #region | Funções |
        public string PorcentagemUsoCPU()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            porcentagemCPU = Convert.ToInt32(cpuCounter.NextValue());

            System.Threading.Thread.Sleep(1000);

            porcentagemCPUStr = Convert.ToInt32(cpuCounter.NextValue()).ToString();

            return porcentagemCPUStr;
        }
        #endregion
    }
}
