namespace CIS420TeamA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RandomChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
        }
    }
}
