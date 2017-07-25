namespace ArenaGame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredFieldsForWeapons : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Weapons", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Weapons", "Name", c => c.String());
        }
    }
}
