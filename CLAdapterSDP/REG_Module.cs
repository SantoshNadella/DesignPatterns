using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAdapterSDP
{
    public class REG_Module : IModule
    {
        string IModule.GetModuleLead()
        {
            return "Eswar";
        }
    }
}
