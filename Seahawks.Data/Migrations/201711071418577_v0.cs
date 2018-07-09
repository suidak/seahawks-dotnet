namespace Seahawks.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserId);
            AddForeignKey("dbo.Appointments", "UserId", "dbo.user", "id");

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "UserId", "dbo.user");
            DropTable("dbo.Appointments");
            
        }
    }
}
