using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Models
{
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
