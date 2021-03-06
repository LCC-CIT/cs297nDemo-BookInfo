namespace BookInfo.Domain.Concrete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequireTitle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Title", c => c.String());
        }
    }
}
