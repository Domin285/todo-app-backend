using System.ComponentModel.DataAnnotations;

namespace ToDoBackend.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = "";

        public string? Description { get; set; }

        public bool IsDone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
