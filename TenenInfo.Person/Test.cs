/* =============================================================================
 * Class file `Test'
 * =============================================================================
 * 
 * Author: Niji System - Satoki Nijikawa / 虹川郷鬼
 * 
 * This class uses methods to initialise objects to be called, as well as deseri-
 * alise JSON files.
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TenenInfo.Person {
    class Test {
        public void TestKun() {
            // Inserts a linebreak after the previous Console.ReadLine()
            Console.Write(Environment.NewLine);
            // All the paths mess...
            string jsonDir = @"data/json/personTest";
            string jsonTestKun0 = $@"{Path.Combine(Environment.CurrentDirectory, @"data/json/personTest", @"Test-kun.json")}";
            string appData = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}";
            string dataFolder = Path.Combine(appData, $@".{Environment.UserName}.data/TenenInfo");
            Directory.CreateDirectory(dataFolder);
            Directory.CreateDirectory($@"{dataFolder}/{jsonDir}");
            string testKunJson = $@"{dataFolder}/{jsonDir}/Test-kun.json";
            // Checks if the JSON in the data folder exists, copies from assembly location if not
            if (File.Exists(testKunJson)) {
                goto CarryOnAsUsual;
            } else {
                File.Copy(jsonTestKun0, $@"{dataFolder}/{jsonDir}/Test-kun.json");
            }
            CarryOnAsUsual:
                string jsonTestKun = $@"{dataFolder}/data/json/personTest/Test-kun.json";
                // Opens the IO stream, reads, and deserialises the JSON
                StreamReader readFile = new StreamReader(jsonTestKun);
                string json = readFile.ReadToEnd();
                var testKun = JsonSerializer.Deserialize<Person>(json);
                // Print the JSON values to console
                Console.WriteLine($"Name: {testKun.Name.First().English}");
                Console.WriteLine($"Japanese: {testKun.Name.First().Japanese} *{testKun.Name.First().Romaji}*");
                Console.WriteLine($"Pronounced /{testKun.Name.First().Pronunciation}/\n");
                Console.WriteLine($"Species: {testKun.Species}");
                Console.WriteLine($"Abilities: {testKun.Ability.First()}\n");
                Console.WriteLine($"Sex assigned at birth: {testKun.SexAssignedAtBirth}");
                Console.WriteLine($"Gender: {testKun.Gender}");
                Console.WriteLine($"Pronouns: {testKun.Pronouns.First().Subjective}/{testKun.Pronouns.First().Objective}/{testKun.Pronouns.First().PossessiveDeterminer}/{testKun.Pronouns.First().PossessivePronoun}/{testKun.Pronouns.First().Reflexive}");
                Console.WriteLine($"Sexuality: {testKun.Sexuality.First()}\n");
                Console.WriteLine($"Height: {testKun.Height.Centimeters} cm ({testKun.Height.FeetAndInches})");
                Console.WriteLine($"Weight: {testKun.Weight.Kilograms} kg (roughly {testKun.Weight.Pounds} lb)\n");
                Console.WriteLine($"Age: {testKun.Age}");
                Console.WriteLine($"DOB: {testKun.Birthday}\n");
                Console.WriteLine($"Family: {testKun.Family.First().Name} ({testKun.Family.First().Age}yo, {testKun.Family.First().Relation})\n");
                Console.WriteLine($"Occupation: {testKun.Occupation}\n");
                // Close the IO stream
                readFile.Close();
            // lausUsAnOyrraC
        }
    }
}