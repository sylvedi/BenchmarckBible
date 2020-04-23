namespace BenchmarckBible.Migrations
{
    using BenchmarckBible.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BenchmarckBible.Models.BibleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BenchmarckBible.Models.BibleDBContext context)
        {
            context.Books.AddOrUpdate( i => i.testament,
                new Book
                {
                    testament = "Old",
                    book = "Genesis",
                    verse = 1,
                    chapter = 1,
                    vtext = "In the beginning God created the heavens and the earth"
                },

                new Book
                {
                    testament = "Old",
                    book = "Numbers",
                    verse = 1,
                    chapter = 6,
                    vtext = "from Simeon, Shelumiel son of Zurishaddai"
                },

                new Book
                {
                    testament = "New",
                    book = "Luke",
                    verse = 1,
                    chapter = 1,
                    vtext = "Many have undertaken to draw up an account of the things that have been fulfilled[a] among us"
                },

                  new Book
                  {
                      testament = "New",
                      book = "John",
                      verse = 3,
                      chapter = 16,
                      vtext = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
                  }

                );
        }
    }
}
