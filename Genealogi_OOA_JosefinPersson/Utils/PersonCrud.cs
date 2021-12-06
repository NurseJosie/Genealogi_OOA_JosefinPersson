using Genealogi_OOA_JosefinPersson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Utils
{
    public class PersonCrud // använd LINQ och SQL!
    {
        public void Create()
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
                Console.WriteLine("New family member added!");
                Console.ReadKey();
            }
 
            // ange personens föräldrar, kolla först om den finns och föreslå den
        }
        public void Read() // lista alla förnamn, efternamn samt Id
        {
            using (var family = new Database())
            {
                var list = family.People.OrderByDescending(f => f.Id);
                foreach (var n in list)
                {
                    Console.WriteLine("- " + n.FirstName + " " + n.LastName + " Id: " + n.Id);
                }
            }
            Console.ReadKey();
        }
        public void ReadFirstLetter()  //lista efter angiven bokstav
        {
            using(var family = new Database())
            {
                Console.WriteLine("Input first letter of firstname:");
                string firstLetter = Console.ReadLine();

                family.People.Where(n => n.FirstName.StartsWith(firstLetter)).ToList().ForEach(person => Console.WriteLine("Firstname: " + person.FirstName + " Lastname: " + person.LastName));
            }
            Console.ReadKey();
        }

        public void ReadBirthYear() //lista efter angivet år
        {
            using (var family = new Database())
            {
                Console.WriteLine("Input birth year:");
                string birthYearInput = Console.ReadLine();
                var birthYear = 0;
                int.TryParse(birthYearInput, out birthYear);

                family.People.Where(n => n.BirthDate == birthYear).ToList().ForEach(person => Console.WriteLine("Firstname: " + person.FirstName + " Lastname: " + person.LastName));
            }
            Console.ReadKey();
        }

        public void Update() //uppdatera vald person, vald property......
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

            Console.ReadKey();
        }
        public void Delete() // välj person, ta bort......
        {
            //using (var filmsamling = new FilmLista())
            //{
            //    var film = filmsamling.Filmer.Where(f => f.TitelEng == "Elf").FirstOrDefault();
            //    if (film != null)
            //        filmsamling.Filmer.Remove(film);

            //}
            Console.ReadKey();
        }

        public void ShowParents() // ange person, visa föräldrars ID......
        {


            Console.ReadKey();
        }

        public void ShowSiblings() // ange person......  SAMMA SOM SHOWCHILDREN?
        {


            Console.ReadKey();
        }

        public void ShowChildren() //visa alla barn till en person......
        {


            Console.ReadKey();
        }

    }

  



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
