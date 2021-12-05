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
                //db.CreateTable<Person>();
                db.People.Add(new Models.Person  //1
                {
                    
                    FirstName = "Rickard",
                    LastName = "Stark",
                    BirthDate = 1500,
                    DeathDate = 1550,
                    MotherId = 0,
                    FatherId = 0,
                   
                });
                db.People.Add(new Models.Person //2
                {
                  
                    FirstName = "Lyarra",
                    LastName = "Stark",
                    BirthDate = 1505,
                    DeathDate = 1549,
                    MotherId = 0,
                    FatherId = 0,
                   
                });
                db.People.Add(new Models.Person //3
                {
                   
                    FirstName = "Ned",
                    LastName = "Stark",
                    BirthDate = 1525,
                    DeathDate = 1565,
                    MotherId = 2,
                    FatherId = 1,
                    
                });
                db.People.Add(new Models.Person
                {
                    
                    FirstName = "Brandon",
                    LastName = "Stark",
                    BirthDate = 1526,
                    DeathDate = 1570,
                    MotherId = 2,
                    FatherId = 1,
                 
                });
                db.People.Add(new Models.Person
                {
                    FirstName = "Benjen",
                    LastName = "Stark",
                    BirthDate = 1527,
                    DeathDate = 1580,
                    MotherId = 2,
                    FatherId = 1,
                });
                db.People.Add(new Models.Person //6
                {
                    FirstName = "Lyanna",
                    LastName = "Stark",
                    BirthDate = 1528,
                    DeathDate = 1548,
                    MotherId = 2,
                    FatherId = 1,
           
                });
                db.People.Add(new Models.Person //7
                {
                    FirstName = "Rhaegar",
                    LastName = "Targaryen",
                    BirthDate = 1520,
                    DeathDate = 1555,
                    MotherId = 0,
                    FatherId = 0,
               
                });
                db.People.Add(new Models.Person //8
                {
                    FirstName = "Catelyn",
                    LastName = "Stark",
                    BirthDate = 1530,
                    DeathDate = 1569,
                    MotherId = 0,
                    FatherId = 0,
         
                });
                db.People.Add(new Models.Person 
                {
                    FirstName = "Robb",
                    LastName = "Stark",
                    BirthDate = 1550,
                    DeathDate = 1569,
                    MotherId = 8,
                    FatherId = 3,

                });
                db.People.Add(new Models.Person
                {
                    FirstName = "Sansa",
                    LastName = "Stark",
                    BirthDate = 1555,
                    DeathDate = 1600,
                    MotherId = 8,
                    FatherId = 3,

                });
                db.People.Add(new Models.Person
                {
                    FirstName = "Arya",
                    LastName = "Stark",
                    BirthDate = 1556,
                    DeathDate = 1620,
                    MotherId = 8,
                    FatherId = 3,
                });
                db.People.Add(new Models.Person
                {
                    FirstName = "Bran",
                    LastName = "Stark",
                    BirthDate = 1557,
                    DeathDate = 1624,
                    MotherId = 8,
                    FatherId = 3,
                });
                db.People.Add(new Models.Person
                {
                    FirstName = "Rickon",
                    LastName = "Stark",
                    BirthDate = 1560,
                    DeathDate = 1570,
                    MotherId = 8,
                    FatherId = 3,
                });
                db.People.Add(new Models.Person
                {
                    FirstName = "Jon",
                    LastName = "Snow",
                    BirthDate = 1551,
                    DeathDate = 1630,
                    MotherId = 6,
                    FatherId = 7,
                });
                db.SaveChanges();
            }
        }
  
    } }

