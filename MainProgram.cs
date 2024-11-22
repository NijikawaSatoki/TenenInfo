﻿/* =============================================================================
 * Ten'en Information
 * =============================================================================
 * 
 * Author: Niji System - Satoki Nijikawa / 虹川郷鬼
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

using Niji.Convenience;
using TenenInfo.Person;

namespace TenenInfo {
    class MainProgram {
        static void Main() {
            Convenience convenience = new Convenience();
            int category;
            int choice;
            Console.WriteLine("Pick a category:");
            Console.WriteLine("0. Test");
            category = convenience.Input32BitInteger();
            switch (category) {
                case 0:
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
                    Console.WriteLine("Only one TwT");
                    break;
                // End of switch block
            }
            Console.WriteLine("Have a nice day.");
            Console.Write("Press <RETURN> on your keyboard to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {}
        }
    }
}