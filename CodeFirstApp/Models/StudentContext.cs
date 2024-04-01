using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstApp.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}