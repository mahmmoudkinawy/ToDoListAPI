using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.DTOs
{
    public class ToDoReadDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; } = false;
    }
}
