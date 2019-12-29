using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBridgeSDP
{
    public class EastGodavari : IGodavari
    {
        string IGodavari.Reach()
        {
            //throw new NotImplementedException();
            return "Reached to East Godavari";
        }
    }
}
