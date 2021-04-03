namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Humen", "lastName", c => c.String());
            AddColumn("dbo.Humen", "age", c => c.Int(nullable: false));
            AddColumn("dbo.Humen", "pol", c => c.Int(nullable: false));
            AddColumn("dbo.Humen", "phone", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Humen", "phone");
            DropColumn("dbo.Humen", "pol");
            DropColumn("dbo.Humen", "age");
            DropColumn("dbo.Humen", "lastName");
        }
    }
}
