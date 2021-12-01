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
