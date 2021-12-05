﻿using Genealogi_OOA_JosefinPersson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Utils
{
    public class PersonCrud // använd LINQ och SQL!
    {
        public void Create(Person p)
        {
            using(var create = new Database())
            {
                Console.WriteLine("Firstname:");
                var createName = Console.ReadLine();

                Console.WriteLine("Lastname:");
                var createLastName = Console.ReadLine();

                Console.WriteLine("Birth year:");
                string input1 = Console.ReadLine();
                var createBirthYear = 0;
                int.TryParse(input1, out createBirthYear);

                Console.WriteLine("Year of death:");
                string input2 = Console.ReadLine();
                var createDeathYear = 0;
                int.TryParse(input2, out createDeathYear);

                Console.WriteLine("Mother(Id):");
                string input3 = Console.ReadLine();
                var createMotherId = 0;
                int.TryParse(input3, out createMotherId);

                Console.WriteLine("Father(Id):");
                string input4 = Console.ReadLine();
                var createFatherId = 0;
                int.TryParse(input4, out createFatherId);

                Person person = new Person()
                {
                    FirstName = createName,
                    LastName = createLastName,
                    BirthDate = createBirthYear,
                    DeathDate = createDeathYear,
                    MotherId = createMotherId,
                    FatherId = createFatherId,
                };

                create.Add(person);
                create.SaveChanges();
            }
            
            // skicka in till DB

            // ange personens föräldrar, spouse och pet! kolla först om den finns och föreslå den
        }
        public void Read()
        {
            //using (var family = new FamilyTree())
            //{
            //    var list = family.StarkFamily.OrderByDescending(f => f.FirstName);
            //    foreach (var n in list)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            // för- och efternamn
        }
        public void ReadFirstLetter(Person p)
        {
            //Console.WriteLine("Input first letter:");
            //string firstLetter = Console.ReadLine();

            //db.Personer.Where(n => n.Namn.StartsWith(firstLetter));
        }

        public void ReadBirthYear(Person p)
        {
            //Console.WriteLine("Input birth year:");
            //string birthYearInput = Console.ReadLine();
            //var birthYear = 0;
            //int.TryParse(birthYearInput, out birthYear);

            //db.Personer.Where(n => n.Namn.StartsWith(firstLetter));
        }

        public void Update(Person p)
        {
            //using (var filmsamling = new FilmLista())
            //{
            //    var film = filmsamling.Filmer.FirstOrDefault(f => f.TitelEng == "Crow");
            //    if (film != null)
            //    {
            //        film.TitelEng = "The Crow";
            //        filmsamling.Filmer.Update(film);
            //        filmsamling.SaveChanges();
            //    }
            //}
        }
        public void Delete(Person p)
        {
            //using (var filmsamling = new FilmLista())
            //{
            //    var film = filmsamling.Filmer.Where(f => f.TitelEng == "Elf").FirstOrDefault();
            //    if (film != null)
            //        filmsamling.Filmer.Remove(film);

            //}
        }

    }

    //Console.WriteLine("1) Create");               PÅBÖRJAD
    //Console.WriteLine("2) Read(Find)");           PÅBÖRJAD
    //Console.WriteLine("3) Update");               PÅBÖRJAD
    //Console.WriteLine("4) Delete");               PÅBÖRJAD
    //Console.WriteLine("5) Namnlista på viss bokstav     PÅBÖRJAD
    //eller födelseår");                                PÅBÖRJAD
    //Console.WriteLine("6) Visa mor- och farföräldrar");
    //Console.WriteLine("7) Visa barn(spec. persons barn?, +husdjur)");
    //VISA SYSKON
    //






    //public class GenealogiCRUD                                                                    EXEMPEL FRÅN PDF
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
