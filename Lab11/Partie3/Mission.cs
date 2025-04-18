using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie3
{
<<<<<<< HEAD
    public partial class Mission
    {
        public void CompleterMission()
        {
            mission.Status = Status.Terminee;
            Console.WriteLine("Allo la terre! Mission terminée");
=======
    public enum Status 
    {
        Planifiee,
        Encours,
        Terminee
    }
    public partial class Mission
    {
        string Nom {  get; set; }
        string Destination { get; set; }
        DateOnly DateDepart {  get; set; }
        DateOnly DateArrive { get; set; }
        Status Status { get; set; }

        public Mission (string nom, string destination, DateOnly dateDepart, DateOnly dateArrive, Status status)
        {
            Nom = nom;
            Destination = destination;
            DateDepart = dateDepart;
            DateArrive = dateArrive;
            Status = status;
>>>>>>> Feature1-Oleksandr04
        }
    }
}
