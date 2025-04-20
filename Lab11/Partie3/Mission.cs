using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Partie3
{
    public enum Status
    {
        Planifiee,
        Encours,
        Terminee
    }
    public partial class Mission
    {
        string Nom {  get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public DateOnly DateDepart {  get; set; }
        public DateOnly DateArrive { get; set; }
        Status Status { get; set; }

        public Mission (string nom, int x, int y, DateOnly dateDepart, DateOnly dateArrive, Status status)
        {
            Nom = nom;
            X = x;
            Y = y;
            DateDepart = dateDepart;
            DateArrive = dateArrive;
            Status = status;
        }
        public void CompleterMission()
        {

                Status = Status.Terminee;
                Console.WriteLine("Allo la terre! Mission terminée");
                Console.WriteLine("Déroulement de la mission le "+DateDepart+" ");
        }
    }
}
