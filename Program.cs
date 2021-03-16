using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Objek Taksi
            Taksi taxi = new Taksi();

            // Setting nilai properties
            taxi.DriverName = "Jati Negara";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // Pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
