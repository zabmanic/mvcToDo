namespace mToDo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoItems",
                c => new
                    {
                        ToDoItemId = c.Int(nullable: false, identity: true),
                        ToDoItemText = c.String(),
                        ToDoItemIsDone = c.String(),
                        ToDoList_ToDoListId = c.Guid(),
                    })
                .PrimaryKey(t => t.ToDoItemId)
                .ForeignKey("dbo.ToDoLists", t => t.ToDoList_ToDoListId)
                .Index(t => t.ToDoList_ToDoListId);
            
            CreateTable(
                "dbo.ToDoLists",
                c => new
                    {
                        ToDoListId = c.Guid(nullable: false),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoListId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoItems", "ToDoList_ToDoListId", "dbo.ToDoLists");
            DropIndex("dbo.ToDoItems", new[] { "ToDoList_ToDoListId" });
            DropTable("dbo.ToDoLists");
            DropTable("dbo.ToDoItems");
        }
    }
}
