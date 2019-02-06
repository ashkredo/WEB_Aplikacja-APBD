using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace s15444.Models
{
    public class OsobyDbContext : DbContext
    {
        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Type> Types { get; set; }
    }  
}