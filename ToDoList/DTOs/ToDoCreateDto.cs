using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.DTOs
{
    public class ToDoCreateDto
    {
        [Required]
        [StringLength(500)]
        public string Text { get; set; }

        public bool Completed { get; set; } = false;
    }
}
