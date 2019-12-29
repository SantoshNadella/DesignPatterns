using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAdapterSDP
{
   public  class QMS_Module:IModule
    {
        string IModule.GetModuleLead()
        {
            return "Naveen";
        }
    }
}
