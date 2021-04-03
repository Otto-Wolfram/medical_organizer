namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Visits", "doc_Id", "dbo.Humen");
            DropForeignKey("dbo.Visits", "pat_Id", "dbo.Humen");
            DropIndex("dbo.Visits", new[] { "doc_Id" });
            DropIndex("dbo.Visits", new[] { "pat_Id" });
            AlterColumn("dbo.Visits", "doc_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Visits", "pat_id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visits", "pat_id", c => c.Int());
            AlterColumn("dbo.Visits", "doc_id", c => c.Int());
            CreateIndex("dbo.Visits", "pat_Id");
            CreateIndex("dbo.Visits", "doc_Id");
            AddForeignKey("dbo.Visits", "pat_Id", "dbo.Humen", "Id");
            AddForeignKey("dbo.Visits", "doc_Id", "dbo.Humen", "Id");
        }
    }
}
