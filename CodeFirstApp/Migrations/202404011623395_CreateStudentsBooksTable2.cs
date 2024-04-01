namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentsBooksTable2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "StudentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "StudentID", c => c.String());
        }
    }
}
