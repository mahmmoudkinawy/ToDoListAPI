using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Data
{
    public interface IToDoRepo
    {
        IEnumerable<ToDoItem> GetAllItems();
        void AddToDo(ToDoItem toDo);
        ToDoItem GetToDoItemById(Guid id);
        bool SaveChanges();
    }
}
