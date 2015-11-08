using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mToDo.Model;
using mToDo.Contracts.Repositories;

namespace mToDo.UI.Controllers
{
    public class ToDoController : Controller
    {
        IRepositoryBase<ToDoItem> toDoItems;

        public ToDoController(IRepositoryBase<ToDoItem> toDoItems)
        {
            this.toDoItems = toDoItems; 
        }

        public ActionResult Index()
        {
            return View("ShowList");
        }

        public ActionResult ShowList()
        {
            var model = toDoItems.GetAll();

            return View(model);
        }
                
        public ActionResult CreateItem()
        {
            var model = new ToDoItem();

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateItem(ToDoItem toDoItem)
        {
            try
            {
                toDoItems.Insert(toDoItem);
                toDoItems.Commit();
                return RedirectToAction("ShowList");
            }
            catch
            {
                return View("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            ToDoItem t = toDoItems.GetById(id);
            return View(t);
        }

        [HttpPost]
        public ActionResult Edit(ToDoItem t)
        {
            try
            {
                toDoItems.Update(t);
                toDoItems.Commit();
                return RedirectToAction("ShowList");
            }
            catch
            {
                return View("ShowList");
            }
        }

        [HttpDelete]
        public ActionResult DeleteItem(int id)
        {
            toDoItems.Delete(id);
            return RedirectToAction("ShowList");
        }

    }
}
