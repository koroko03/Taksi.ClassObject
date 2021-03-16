using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi
{
    public class Taksi
    {
        // Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else if (OnDuty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            Console.WriteLine("\n");
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
        }
    }
}
