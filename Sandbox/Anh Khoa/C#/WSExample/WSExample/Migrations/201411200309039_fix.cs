namespace WSExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.User", "Class_Id", "dbo.Class");
            DropIndex("dbo.User", new[] { "Class_Id" });
            RenameColumn(table: "dbo.User", name: "Class_Id", newName: "ClassID");
            AddForeignKey("dbo.User", "ClassID", "dbo.Class", "Id", cascadeDelete: true);
            CreateIndex("dbo.User", "ClassID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.User", new[] { "ClassID" });
            DropForeignKey("dbo.User", "ClassID", "dbo.Class");
            RenameColumn(table: "dbo.User", name: "ClassID", newName: "Class_Id");
            CreateIndex("dbo.User", "Class_Id");
            AddForeignKey("dbo.User", "Class_Id", "dbo.Class", "Id");
        }
    }
}
