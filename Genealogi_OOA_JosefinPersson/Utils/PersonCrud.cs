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
            }
            
            // skicka in till DB

            // ange personens föräldrar, spouse och pet!
        }
        public void Read(string name, string lastname)
        {
            // för- och efternamn
        }
        public void Read(Person p)
        {
            // ?
        }
        public void Read(int id)
        {
            // sök på Id
        }
        public void Update(Person p)
        {

        }
        public void Delete(Person p)
        {

        }
        public void Delete(int id)
        {

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
