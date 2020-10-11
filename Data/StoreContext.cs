using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
namespace DatabaseFromApplication.Data
{
        public class StoreContext : DbContext
        {
            public StoreContext(DbContextOptions<StoreContext> options)
                : base(options)
            {

            }
            public DbSet<Stores> Stores { get; set; }


            //public DbSet<BookGallery> BookGallery { get; set; }

            //public DbSet<Language> Language { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=.; Database = Stores; Integrated Security = True");
                base.OnConfiguring(optionsBuilder);

            }
        }

    }