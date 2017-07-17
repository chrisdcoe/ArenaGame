namespace ArenaGame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MinDamage = c.Int(nullable: false),
                        MaxDamage = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weapons");
        }
    }
}
