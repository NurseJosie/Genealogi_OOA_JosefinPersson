using Genealogi_OOA_JosefinPersson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Utils
{
    public class PersonCrud 
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

        public void Update() //uppdatera vald person, alla properties
        {
            using (var update = new Database())
            {
                Console.WriteLine("Input firstname of the family member you wish to update:");
                var inputName = Console.ReadLine();

                var u = update.People.Where(f => f.FirstName == inputName).FirstOrDefault();
                if (u != null)
                {
                    Console.WriteLine("Firstname:");
                    var newName = Console.ReadLine();
                    u.FirstName = newName;

                    Console.WriteLine("Lastname:");
                    var newLastName = Console.ReadLine();
                    u.LastName = newLastName;

                    Console.WriteLine("Birth year:");
                    string birthInput = Console.ReadLine();
                    var newBirth = 0;
                    int.TryParse(birthInput, out newBirth);
                    u.BirthDate = newBirth;

                    Console.WriteLine("Year of death:");
                    string deathInput = Console.ReadLine();
                    var newDeath = 0;
                    int.TryParse(deathInput, out newDeath);
                    u.DeathDate = newDeath;

                    Console.WriteLine("Id of mother:");
                    string momInput = Console.ReadLine();
                    var newMom = 0;
                    int.TryParse(momInput, out newMom);
                    u.MotherId = newMom;

                    Console.WriteLine("Id of father:");
                    string dadInput = Console.ReadLine();
                    var newDad = 0;
                    int.TryParse(dadInput, out newDad);
                    u.FatherId = newDad;

                    update.People.Update(u);
                    update.SaveChanges();
                    Console.WriteLine("Family member updated!");
                }
                else Console.WriteLine("Cannot find family member with that firstname!");
            }
            Console.ReadKey();
        }
        public void Delete() // ange förnamn, ta bort
        {
            using (var delete = new Database())
            {
                Console.WriteLine("Input firstname of the family member you wish to delete:");
                var inputName = Console.ReadLine();

                var d = delete.People.Where(f => f.FirstName == inputName).FirstOrDefault();
                if (d != null) 
                {
                    delete.People.Remove(d);
                    delete.SaveChanges();
                    Console.WriteLine("Family member deleted!");
                }
                else Console.WriteLine("Cannot find family member with that firstname!");
            }         
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
}
