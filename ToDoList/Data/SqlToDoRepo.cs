using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class SqlToDoRepo : IToDoRepo
    {
        private readonly ToDoDbContext _context;

        public SqlToDoRepo(ToDoDbContext context)
        {
            _context = context;
        }
        public void AddToDo(ToDoItem toDo)
        {
            _context.ToDoItems.Add(toDo);
        }

        public IEnumerable<ToDoItem> GetAllItems()
        {
            return _context.ToDoItems.ToList();
        }

        public void UpdateToDo(ToDoItem toDo)
        {
            //No code here
            //_context.ToDoItems.Update(toDo);


            var toDoItem = _context.ToDoItems.SingleOrDefault(kh => kh.Id == toDo.Id);

            if (toDoItem != null)
            {
                toDoItem.Text = toDo.Text;
                toDoItem.Completed = toDo.Completed;
            }

        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public ToDoItem GetToDoItemById(Guid id)
        {
            return _context.ToDoItems.Find(id);
        }
    }
}
