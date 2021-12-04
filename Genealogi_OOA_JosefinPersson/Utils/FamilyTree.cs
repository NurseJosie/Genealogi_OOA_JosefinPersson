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
                    Id = 1, //lägg till manuellt?
                    FirstName = "Rickard",
                    LastName = "Stark",
                    BirthDate = 1900,
                    DeathDate = 1950,
                    MotherId = 0,
                    FatherId = 0,
                    //Pets = new List<Pet>
                    //    {
                    //    }
                });
                db.SaveChanges();
            }
        }


        //husdjuren
    } }

