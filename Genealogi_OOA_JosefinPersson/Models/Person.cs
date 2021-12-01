using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Models
{
    public class History //behövs för G?
    {
        [Key] //?
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string Event { get; set; } 
    }

    public class Spouse //för att kunna få med omgifte, behövs för G?
    {
        [Key]//?
        public int Id { get; set; }
        public Person SpouseA { get; set; }
        public Person SpouseB { get; set; }
    }

    public class Pet
    {
        [Key]//?
        public int Id { get; set; }
        public Person Owner { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; } // DateTime? VG! År räcker!
        public string DeathDate { get; set; } // DateTime? VG! År räcker!
        public Pet MotherId { get; set; } // ange Id på personen, kommer ej anges för hundarna
        public Pet FatherId { get; set; } // ange Id på personen, kommer ej anges för hundarna
    }

    public class Person
    { 
        [Key]//?
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string BirthDate { get; set; } // DateTime? VG! År räcker!
        public string DeathDate { get; set; } // DateTime? VG! År räcker!
        public int MotherId { get; set; } // ange Id på personen
        public int FatherId { get; set; } // ange Id på personen
        public List<Spouse> Spouses { get; set; } //behövs för G? Vill ändå ha med!
        public List<History> History { get; set; } //behövs för G? Vill ändå ha med!
        public List<Pet> Pets { get; set; } //behövs för G? Vill ändå ha med! List?
    }
}
