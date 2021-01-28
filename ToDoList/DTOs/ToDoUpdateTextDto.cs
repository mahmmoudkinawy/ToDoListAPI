using System.ComponentModel.DataAnnotations;

namespace ToDoList.DTOs
{
    public class ToDoUpdateTextDto
    {
        [Required]
        [StringLength(500)]
        public string Text { get; set; }
    }
}
