using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models
{
    public class MyViewModel
    {
        //public IEnumerable<Student> Students { get; set; }
        //public IEnumerable<Book> Books { get; set; }

        public List<Student> Students { get; set; }
        public List<Book> Books { get; set; }
    }
}