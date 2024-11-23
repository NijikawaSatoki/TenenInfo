/* =============================================================================
 * Ten'en Information
 * =============================================================================
 * 
 * Author: Niji System - Satoki Nijikawa / 虹川郷鬼
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;

using Niji.Convenience;
using TenenInfo.Person;

namespace TenenInfo {
    class MainProgram {
        static void Main() {
            // Force UTF-8 encoding, since C# doesn't seem to do it right :(
            Console.OutputEncoding = Encoding.UTF8;
            // Initialise objects
            Convenience convenience = new Convenience();
            ZoukagamirokuCategory zoukagamiroku = new ZoukagamirokuCategory();
            // Initialise variables
            int category;
            // Ask the user for their input
            Console.WriteLine("Pick a category:");
            Console.WriteLine("0. Test");
            category = convenience.Input32BitInteger();
            // Check against user input
            switch (category) {
                case 0:
                    zoukagamiroku.Test();
                    break;
                // End of switch block
            }
            // Send the user on their way
            Console.WriteLine("Have a nice day.");
            Console.WriteLine("Press <RETURN> on your keyboard to exit... ");
            do {
                while (!Console.KeyAvailable) {
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write("\r   \r");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            Console.Write(Environment.NewLine);
        }
    }
}
