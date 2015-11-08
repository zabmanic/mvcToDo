using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mToDo.Model
{
    public class ToDoList
    {
        public Guid ToDoListId { get; set; }
        public DateTime date { get; set; }

        public ToDoList()
        {
            this.ToDoItems = new List<ToDoItem>();
        }

        public ICollection<ToDoItem> ToDoItems { get; set; }
    }
}
