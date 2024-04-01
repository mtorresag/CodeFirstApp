namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentsBooksTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        StudentID = c.String(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.Student_StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Student_StudentID", "dbo.Students");
            DropIndex("dbo.Books", new[] { "Student_StudentID" });
            DropTable("dbo.Books");
        }
    }
}
