namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSuscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.customers", "IsSuscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.customers", "IsSuscribedToNewsLetter");
        }
    }
}
