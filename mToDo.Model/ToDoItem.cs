using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mToDo.Model
{
    public class ToDoItem
    {
        public int ToDoItemId { get; set; }
        //public Guid ToDoListId { get; set; }
        public string ToDoItemText { get; set; }
     
        public bool ToDoItemIsDone { get; set; }
    }
}
