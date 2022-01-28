namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) values (1,'Jazz')");
            Sql("INSERT INTO GENRES (Id, Name) values (2,'Blues')");
            Sql("INSERT INTO GENRES (Id, Name) values (3,'Rock')");
            Sql("INSERT INTO GENRES (Id, Name) values (4,'Pop')");
            Sql("INSERT INTO GENRES (Id, Name) values (5,'Country')");
        }

        public override void Down()
        {
            Sql("DELETE from Genres Where Id IN (1,2,3,4,5)");
        }
    }
}
