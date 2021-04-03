namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Humen", "JobTime", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Humen", "JobTime");
        }
    }
}
