namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Humen", "position", c => c.Int());
            AddColumn("dbo.Humen", "polisNum", c => c.Long());
            AddColumn("dbo.Humen", "diagnos", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Humen", "diagnos");
            DropColumn("dbo.Humen", "polisNum");
            DropColumn("dbo.Humen", "position");
        }
    }
}
