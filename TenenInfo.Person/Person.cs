/* =============================================================================
 * Class file `Person'
 * =============================================================================
 * 
 * Author: Niji System - Satoki Nijikawa / 虹川郷鬼
 * 
 * This class just sets up the class for deserialising from JSON
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace TenenInfo.Person {
    // Base class
    public class Person {
        public List<Name> Name { get; set; }
        public string Species { get; set; }
        public List<string> Ability { get; set; }
        public string SexAssignedAtBirth { get; set; }
        public string Gender { get; set; }
        public List<Pronoun> Pronouns { get; set; }
        public List<string> Sexuality { get; set; }
        public Height Height { get; set; }
        public Weight Weight { get; set; }
        public long Age { get; set; }
        public string Birthday { get; set; }
        public List<Family> Family { get; set; }
        public string Occupation { get; set; }
        public string SkinTone { get; set; }
        public string HairColor { get; set; }
        public EyeColor EyeColor { get; set; }
        public List<string> Biography { get; set; }
    }
    // Classes for the other JSON properties
    public class Name {
        public string English { get; set; }
        public string Japanese { get; set; }
        public string Romaji { get; set; }
        public string Pronunciation { get; set; }
    }
    public class Pronoun {
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string PossessiveDeterminer { get; set; }
        public string PossessivePronoun { get; set; }
        public string Reflexive { get; set; }
    }
    public class Height {
        public double Centimeters { get; set; } // Metric
        public string FeetAndInches { get; set; } // Imperial (stupid Americans)
    }
    public class Weight {
        public double Kilograms { get; set; } // Metric
        public double Pounds { get; set; } // Imperial (stupid Americans)
    }
    public class Family {
        public string Name { get; set; }
        public long Age { get; set; }
        public string Relation { get; set; }
    }
    public class EyeColor {
        public string RightEye { get; set; }
        public string LeftEye { get; set; }
    }
}
