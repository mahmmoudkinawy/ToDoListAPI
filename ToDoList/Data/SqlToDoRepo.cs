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
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public void AddToDo(ToDoItem toDo)
        {
            _context.ToDoItems.Add(toDo);
        }

        public IEnumerable<ToDoItem> GetAllItems()
        {
            return _context.ToDoItems.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public ToDoItem GetToDoItemById(Guid id)
        {
            return _context.ToDoItems.Find(id);
        }

        public IEnumerable<ToDoItem> GetUnCompletedToDos(Guid userId)
        {
            //return _context.ToDoItems.Where(todo => !todo.Completed);

            return from r in _context.ToDoItems
                   where !r.Completed && r.UserId == userId
                   select r;
        }
    }
}
