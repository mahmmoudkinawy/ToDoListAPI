﻿using Microsoft.EntityFrameworkCore;
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
