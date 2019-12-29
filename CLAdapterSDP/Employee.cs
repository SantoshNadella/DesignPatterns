using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAdapterSDP
{
    public class Employee
    {
        public string LeadOn(IModule obj)
        {
            //return obj.GetModuleLead();
            return ModuleLeadAdaptor.GetModuleLead(obj);
        }
    }
}
