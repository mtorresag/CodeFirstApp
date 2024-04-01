using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Nombre { get; set; }
        
        public Student Student { get; set; } // Propiedad de navegación
    }
}
