namespace BenchmarckBible.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        testament = c.String(),
                        book = c.String(maxLength: 100),
                        verse = c.Int(nullable: false),
                        chapter = c.Int(nullable: false),
                        vtext = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
