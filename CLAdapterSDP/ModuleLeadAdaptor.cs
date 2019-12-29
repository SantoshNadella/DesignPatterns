using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAdapterSDP
{
    public class ModuleLeadAdaptor : IModule
    {
        string IModule.GetModuleLead()
        {
            return "";
        }
        public static string GetModuleLead(IModule obj)
        {
            return obj.GetModuleLead();
        }
    }
}
