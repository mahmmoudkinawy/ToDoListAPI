using System.ComponentModel.DataAnnotations;

namespace ToDoList.DTOs
{
    public class ToDoUpdateCompleteDto
    {
        [Required]
        public bool Completed { get; set; } = false;
    }
}
