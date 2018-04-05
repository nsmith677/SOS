namespace CIS420TeamA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Email : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.NonClinicalGenerals");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NonClinicalGenerals",
                c => new
                    {
                        VolunteerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Birthday = c.String(),
                        Occupation = c.String(),
                        AreaOfInterest = c.String(),
                        WhyServeSOS = c.String(),
                    })
                .PrimaryKey(t => t.VolunteerID);
            
        }
    }
}
