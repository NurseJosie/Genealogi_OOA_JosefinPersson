using Genealogi_OOA_JosefinPersson.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson
{
    public class Database:DbContext  // databasklassen
    {
        //databaskoppling och dbsets här
        private const string DatabaseName = "JPGenealogi";
        private const string ConnString = "server=(localdb)\\mssqllocaldb;integrated security=true;database = JPGenealogi";     // 
        public DbSet<Person> People { get; set; }
        public DbSet<Pet> Pets { get; set; }
        ////public DbSet<Spouse> Spouses { get; set; }
        //public DbSet<History> History { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // var conn=string.Format(ConnString, DatabaseName);
            optionsBuilder.UseSqlServer(ConnString);   
            base.OnConfiguring(optionsBuilder);
        }
    }

    //public static class InitializeDatabase //Fyller en nyskapad databas med grunddata, kan också kallas Seeder
    //{
    //    public static void Seed() // här fylls databasen med data
    //    {

    //    }

    //}
}
