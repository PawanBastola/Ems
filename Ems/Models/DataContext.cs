using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration
                ["ConnectionStrings:DefaultConnection"]);

        }

        //need to register your model here 
        //public Dbset<product> Products{get;set;}

        public DbSet<Answers> answerss { get; set; }
        public DbSet<Options> optionss { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Userlogin> userlogins { get; set; }


    }
}

