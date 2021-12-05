using Genealogi_OOA_JosefinPersson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Utils
{
    public class FamilyTree {

        //familjen 
        public void StarkFamily()
        {
            using (var db = new Database())
            {
                db.People.Add(new Models.Person
                {
                    //Id = 1, //lägg till manuellt?
                    FirstName = "Rickard",
                    LastName = "Stark",
                    BirthDate = 1500,
                    DeathDate = 1550,
                    MotherId = 0,
                    FatherId = 0,
                    //Pets = new List<Pet>
                    //{
                    //}
                    //Spouses = new List<Spouse>()
                    //{
                    //    I
                    //}
                });
                db.People.Add(new Models.Person
                {
                    //Id = 1, //lägg till manuellt?
                    FirstName = "Lyarra",
                    LastName = "Stark",
                    BirthDate = 1505,
                    DeathDate = 1549,
                    MotherId = 0,
                    FatherId = 0,
                    //Pets = new List<Pet>
                    //{
                    //}
                });
                db.People.Add(new Models.Person
                {
                    //Id = 1, //lägg till manuellt?
                    FirstName = "Ned",
                    LastName = "Stark",
                    BirthDate = 1525,
                    DeathDate = 1565,
                    MotherId = 2,
                    FatherId = 1,
                    //Pets = new List<Pet>
                    //{
                    //}
                });
                db.People.Add(new Models.Person
                {
                    //Id = 1, //lägg till manuellt?
                    FirstName = "Brandon",
                    LastName = "Stark",
                    BirthDate = 1526,
                    DeathDate = 1570,
                    MotherId = 2,
                    FatherId = 1,
                    //Pets = new List<Pet>
                    //{
                    //}
                });
                db.People.Add(new Models.Person
                {
                    //Id = 1, //lägg till manuellt?
                    FirstName = "Benjen",
                    LastName = "Stark",
                    BirthDate = 1527,
                    DeathDate = 1580,
                    MotherId = 2,
                    FatherId = 1,
                    //Pets = new List<Pet>
                    //{
                    //}
                });
                db.People.Add(new Models.Person
                {
                    //Id = 1, //lägg till manuellt?
                    FirstName = "Lyanna",
                    LastName = "Stark",
                    BirthDate = 1528,
                    DeathDate = 1548,
                    MotherId = 2,
                    FatherId = 1,
                    //Pets = new List<Pet>
                    //{
                    //}
                });
                db.People.Add(new Models.Person
                {
                    //Id = 1, //lägg till manuellt?
                    FirstName = "Rhaegar",
                    LastName = "Targaryen",
                    BirthDate = 1520,
                    DeathDate = 1555,
                    MotherId = 0,
                    FatherId = 0,
                    //Pets = new List<Pet>
                    //{
                    //}
                });
                db.People.Add(new Models.Person
                {
                    //Id = 1, //lägg till manuellt?
                    FirstName = "Catelyn",
                    LastName = "Stark",
                    BirthDate = 1530,
                    DeathDate = 1569,
                    MotherId = 0,
                    FatherId = 0,
                    //Pets = new List<Pet>
                    //{
                    //}
                });

                db.SaveChanges();
            }
        }
        //Spouses/ partners
        //public void Partners()
        //{
        //    using (var db = new Database())
        //    {
        //        db.People.Add(new Models.Spouse
        //        {
        //            //Id = 1, //lägg till manuellt?
        //            SpouseA = 1, //rickard
        //            SpouseB = 2, //lyarra
        //        });


        //        db.SaveChanges();
        //    }
        //}

        //husdjuren
    } }

