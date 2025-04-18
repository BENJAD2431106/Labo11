using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
    public partial class Mission
    {
        public void CompleterMission()
        {
            mission.Status = Status.Terminee;
            Console.WriteLine("Allo la terre! Mission terminée");
        }
    }
}
