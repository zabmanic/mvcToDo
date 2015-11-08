using mToDo.DAL.Data;
using mToDo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mToDo.DAL.Repositories
{
    public class ToDoItemRepository : RepositoryBase<ToDoItem>
    {
        public ToDoItemRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
