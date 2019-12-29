using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBridgeSDP
{
    public class WestGodavari : IGodavari
    {
        string IGodavari.Reach()
        {
            return "Reached to West Godavari";
        }
    }
}
