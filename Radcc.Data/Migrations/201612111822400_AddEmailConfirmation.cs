namespace Radcc.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailConfirmation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUsers", "ConfirmedEmail", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationUsers", "ConfirmedEmail");
        }
    }
}
