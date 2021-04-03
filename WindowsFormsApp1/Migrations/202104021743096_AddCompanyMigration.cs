namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Humen", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Humen", "name");
        }
    }
}
