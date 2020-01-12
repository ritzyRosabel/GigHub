namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
             Sql("DELETE FROM Genres WHERE Id IN (5,6,7,8)");

        }

        public override void Down()
        {

            Sql("INSERT INTO Genres (Id ,Name) VALUES (5,'Jazz')");
            Sql("INSERT INTO Genres (Id ,Name) VALUES (6,'RandB')");
            Sql("INSERT INTO Genres (Id ,Name) VALUES (7,'Accapella')");
            Sql("INSERT INTO Genres (Id ,Name) VALUES (8,'Country')");
        }
    }
}
