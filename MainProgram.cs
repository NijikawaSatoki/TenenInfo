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

using Niji.Convenience;
using TenenInfo.Person;

namespace TenenInfo {
    class MainProgram {
        static void Main() {
            // Force UTF-8 encoding, since C# doesn't seem to do it right :(
            Console.OutputEncoding = Encoding.UTF8;
            // Initialise objects
            Convenience convenience = new Convenience();
            // Initialise variables
            int category;
            int choice;
            // Ask the user for their input
            Console.WriteLine("Pick a category:");
            Console.WriteLine("0. Test");
            category = convenience.Input32BitInteger();
            // Check against user input
            switch (category) {
                case 0:
                    // Ask the user for input
                    Console.WriteLine("Whose info do you want?");
                    Console.WriteLine("1. Test-kun");
                    choice = convenience.Input32BitInteger();
                    // Check against user input
                    switch (choice) {
                        case 1:
                            var testKun = new Test();
                            testKun.TestKun();
                            break;
                        // End of switch block
                    }
                    Console.WriteLine("Only one TwT");
                    break;
                // End of switch block
            }
            // Send the user on their way
            Console.WriteLine("Have a nice day.");
            Console.WriteLine("Press <RETURN> on your keyboard to exit... ");
            do {
                while (!Console.KeyAvailable) {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write("\r   \r");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            Console.Write(Environment.NewLine);
        }
    }
}
