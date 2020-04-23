using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BenchmarckBible.Models
{
    public class Book
    {
        public int id { get; set; }

        [StringLength(14, MinimumLength = 3)]
        public string testament { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string book { get; set; }

        [Range(1, 10000)]
        [Required]
 
        public int verse { get; set; }

        [Range(1, 1000)]
        [Required]
       
        public int chapter { get; set; }

        [Required]
        public string vtext { get; set; }
    }

    public class BibleDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}