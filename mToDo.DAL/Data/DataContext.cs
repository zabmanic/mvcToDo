using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using mToDo.Model; 

namespace mToDo.DAL.Data
{
    public class DataContext : DbContext 
    {
        public DataContext() 
            : base(@"Application Name=mToDo;Persist Security Info=False;Initial Catalog=mToDo;Data Source=.\SQLEXPRESS2014; Connect Timeout=60;Trusted_Connection=yes")
        {
        }

        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }

    }
           
}
