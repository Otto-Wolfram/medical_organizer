namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        doc_Id = c.Int(),
                        pat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Humen", t => t.doc_Id)
                .ForeignKey("dbo.Humen", t => t.pat_Id)
                .Index(t => t.doc_Id)
                .Index(t => t.pat_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visits", "pat_Id", "dbo.Humen");
            DropForeignKey("dbo.Visits", "doc_Id", "dbo.Humen");
            DropIndex("dbo.Visits", new[] { "pat_Id" });
            DropIndex("dbo.Visits", new[] { "doc_Id" });
            DropTable("dbo.Visits");
        }
    }
}
