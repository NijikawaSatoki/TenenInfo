/* =============================================================================
 * Class file `Test'
 * =============================================================================
 * 
 * Author: Niji System - Satoki Nijikawa / 虹川郷鬼
 * 
 * This class solely serves as a template for the classes that deserialise the 
 * character JSON files.
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TenenInfo.Person
{
    class PersonTemplate
    {
        public void TemplateToFollow()
        {
            // Inserts a linebreak after the previous Console.ReadLine()
            Console.Write(Environment.NewLine);
            // All the paths mess...
            string jsonDir = @"data/json/.template";
            string jsonTemplateDat = $@"{Path.Combine(Environment.CurrentDirectory, @"data/json/.template", @"template.json")}";
            string appData = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}";
            string dataFolder = Path.Combine(appData, $@".{Environment.UserName}.data/TenenInfo");
            Directory.CreateDirectory(dataFolder);
            Directory.CreateDirectory($@"{dataFolder}/{jsonDir}");
            string templateJson = $@"{dataFolder}/{jsonDir}/template.json";
            // Checks if the JSON in the data folder exists, copies from assembly location if not
            if (File.Exists(templateJson))
            {
                Console.WriteLine("All files are already copied to where they need to be.");
            }
            else
            {
                File.Copy(jsonTemplateDat, $@"{dataFolder}/{jsonDir}/template.json");
            }
            string jsonTemplate = $@"{dataFolder}/data/json/.template/template.json";
            // Opens the IO stream, reads, and deserialises the JSON
            StreamReader readFile = new StreamReader(jsonTemplate);
            string json = readFile.ReadToEnd();
            var template = JsonSerializer.Deserialize<Person>(json);
            // Place the JSON values into variables (hopefully improves readablity)
            string[] nameEnglish = {
                template.Name.ElementAt(0).English
            };
            string[] nameJapanese = {
                template.Name.ElementAt(0).Japanese
            };
            string[] nameRomaji = {
                template.Name.ElementAt(0).Romaji
            };
            string[] ipa = {
                template.Name.ElementAt(0).Pronunciation
            };
            string species = template.Species;
            string[] ability = {
                template.Ability.ElementAt(0)
            };
            string sex = template.SexAssignedAtBirth;
            string gender = template.Gender;
            string[,] pronouns = {
                {
                    template.Pronouns.ElementAt(0).Subjective, template.Pronouns.ElementAt(0).Objective, template.Pronouns.ElementAt(0).PossessiveDeterminer, template.Pronouns.ElementAt(0).PossessivePronoun, template.Pronouns.ElementAt(0).Reflexive
                }
            };
            string[] sexuality = {
                template.Sexuality.ElementAt(0)
            };
            double heightCm = template.Height.Centimeters;
            string heightFtIn = template.Height.FeetAndInches;
            double weightKg = template.Weight.Kilograms;
            double weightLb = template.Weight.Pounds;
            long age = template.Age;
            string dateOfBirth = template.Birthday;
            string[] familyMemberName = {
                template.Family.ElementAt(0).Name
            };
            long[] familyMemberAge = {
                template.Family.ElementAt(0).Age
            };
            string[] familyMemberRelation = {
                template.Family.ElementAt(0).Relation
            };
            string job = template.Occupation;
            string colorSkin = template.SkinTone;
            string colorHair = template.HairColor;
            string colorRightEye = template.EyeColor.RightEye;
            string colorLeftEye = template.EyeColor.LeftEye;
            string[] bio = {
                template.Biography.ElementAt(0)
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
        }
    }
}
