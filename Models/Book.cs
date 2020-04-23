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
        public string testament { get; set; }
        public string book { get; set; }
        public int verse { get; set; }
        public int chapter { get; set; }
        public string vtext { get; set; }
    }

    public class BibleDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}