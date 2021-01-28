using System.ComponentModel.DataAnnotations;

namespace ToDoList.DTOs
{
    public class ToDoUpdateCompleteDto
    {
        public bool Completed { get; set; } = false;
    }
}
