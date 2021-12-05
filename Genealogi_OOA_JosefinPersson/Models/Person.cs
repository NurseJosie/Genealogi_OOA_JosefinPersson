﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Models
{
    //public class History //behövs för G?
    //{
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }
    //    public DateTime EventDate { get; set; }
    //    public string Event { get; set; } 
    //}

    public class Spouse //för att kunna få med omgifte, behövs för G?
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Person SpouseA { get; set; }
        public Person SpouseB { get; set; }
    }

    //public class Pet
    //{
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }
    //    public Person Owner { get; set; }
    //    public string Name { get; set; }
    //    public string BirthDate { get; set; } // DateTime? År räcker!
    //    public string DeathDate { get; set; } // DateTime? År räcker!
    //    //public Pet MotherId { get; set; } // ange Id på personen, kommer ej anges för hundarna
    //    //public Pet FatherId { get; set; } // ange Id på personen, kommer ej anges för hundarna
    //}

    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDate { get; set; } // DateTime? År räcker!
        public int DeathDate { get; set; } // DateTime? År räcker!
        public int MotherId { get; set; } // ange Id på personen
        public int FatherId { get; set; } // ange Id på personen
        public List<Spouse> Spouses { get; set; } //behövs för G? Vill ändå ha med!

        public static implicit operator Person(int v)
        {
            throw new NotImplementedException();
        }
        //public List<History> History { get; set; } //behövs för G? Vill ändå ha med!
        //public List<Pet> Pets { get; set; } //behövs för G? Vill ändå ha med! List?
    }

    //public class GenealogiCRUD                                                             från PDF   HÖR TILL PersonCrud.cs
    //{
    //    public string DatabaseName { get; set; } = "Genealogi";
    //    public int MaxRows { get; set; } = 10; // Max rows to return when searching
    //    public string OrderBy { get; set; } = "lastName";
    //    public void Create(Person person) {/* Massor med kod */}
    //    public void Delete(Person person) {/* Massor med kod */}
    //    public bool DoesPersonExist(string name) {/* Massor med kod */}
    //    public bool DoesPersonExist(int Id) {/* Massor med kod */}
    //    public void GetFather(Person person) {/* Massor med kod */}
    //    public void GetMother(Person person) {/* Massor med kod */}
    //    public List<Person> List(string filter = "firstName", string paramValue) {/* Massor med kod */}
    //    public Person Read(string name) {/* Massor med kod */}
    //    public void Update(Person person) {/* Massor med kod */}
    //}
}
