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
using System.Collections.Immutable;
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
                // Place the JSON values into variables (hopefully improves readablity)
                string[] nameEnglish = {
                    testKun.Name.ElementAt(0).English
                };
                string[] nameJapanese = {
                    testKun.Name.ElementAt(0).Japanese
                };
                string[] nameRomaji = {
                    testKun.Name.ElementAt(0).Romaji
                };
                string[] ipa = {
                    testKun.Name.ElementAt(0).Pronunciation
                };
                string species = testKun.Species;
                string[] ability = {
                    testKun.Ability.ElementAt(0)
                };
                string sex = testKun.SexAssignedAtBirth;
                string gender = testKun.Gender;
                string[,] pronouns = {
                    {
                        testKun.Pronouns.ElementAt(0).Subjective, testKun.Pronouns.ElementAt(0).Objective, testKun.Pronouns.ElementAt(0).PossessiveDeterminer, testKun.Pronouns.ElementAt(0).PossessivePronoun, testKun.Pronouns.ElementAt(0).Reflexive
                    }
                };
                string[] sexuality = {
                    testKun.Sexuality.ElementAt(0)
                };
                double heightCm = testKun.Height.Centimeters;
                string heightFtIn = testKun.Height.FeetAndInches;
                double weightKg = testKun.Weight.Kilograms;
                double weightLb = testKun.Weight.Pounds;
                long age = testKun.Age;
                string dateOfBirth = testKun.Birthday;
                string[] familyMemberName = {
                    testKun.Family.ElementAt(0).Name
                };
                long[] familyMemberAge = {
                    testKun.Family.ElementAt(0).Age
                };
                string[] familyMemberRelation = {
                    testKun.Family.ElementAt(0).Relation
                };
                string job = testKun.Occupation;
                string colorSkin = testKun.SkinTone;
                string colorHair = testKun.HairColor;
                string colorRightEye = testKun.EyeColor.RightEye;
                string colorLeftEye = testKun.EyeColor.LeftEye;
                string[] bio = {
                    testKun.Biography.ElementAt(0)
                };
                // Print the JSON values to console
                Console.WriteLine($"Name: {nameEnglish[0]}");
                Console.WriteLine($"Japanese: {nameJapanese[0]} *{nameRomaji[0]}*");
                Console.WriteLine($"Pronounced /{ipa[0]}/\n");
                Console.WriteLine($"Species: {species}");
                Console.WriteLine($"Abilities: {ability[0]}\n");
                Console.WriteLine($"Sex assigned at birth: {sex}");
                Console.WriteLine($"Gender: {gender}");
                Console.WriteLine($"Pronouns: {pronouns[0, 0]}/{pronouns[0, 1]}/{pronouns[0, 2]}/{pronouns[0, 3]}/{pronouns[0, 4]}");
                Console.WriteLine($"Sexuality: {sexuality[0]}\n");
                Console.WriteLine($"Height: {heightCm} cm ({heightFtIn})");
                Console.WriteLine($"Weight: {weightKg} kg (roughly {weightLb} lb)\n");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"DOB: {dateOfBirth}\n");
                Console.WriteLine($"Family: {familyMemberName} ({familyMemberAge}yo, {familyMemberRelation})\n");
                Console.WriteLine($"Occupation: {job}\n");
                Console.WriteLine($"Skin Tone: #{colorSkin}");
                Console.WriteLine($"Hair colour: #{colorHair}");
                Console.WriteLine($"Eye colour(s): #{colorRightEye} (right eye), {colorLeftEye} (left eye)\n");
                Console.WriteLine($"{bio[0]}\n");
                // Close the IO stream
                readFile.Close();
            // lausUsAnOyrraC
        }
    }
}
