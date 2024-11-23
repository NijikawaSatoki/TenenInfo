using Niji.Convenience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenenInfo.Person;

namespace TenenInfo {
    public class ZoukagamirokuCategory {
        public void Test() {
            // Initialise objects
            Convenience convenience = new Convenience();
            // Initialise variables
            int choice;
            // Ask the user for input
            Console.WriteLine("Whose info do you want?");
            Console.WriteLine("1. Test-kun");
            choice = convenience.Input32BitInteger();
            switch (choice) {
                case 1:
                    var testKun = new Test();
                    testKun.TestKun();
                    break;
                // End of switch block
            }
        }
    }
}
