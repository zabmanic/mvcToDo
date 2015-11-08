namespace mToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isDone_change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ToDoItems", "ToDoItemIsDone", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ToDoItems", "ToDoItemIsDone", c => c.String());
        }
    }
}
