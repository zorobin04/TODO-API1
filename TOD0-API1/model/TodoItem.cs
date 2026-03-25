using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? CompletedAt { get; set; }

        public Priority Priority { get; set; } = Priority.Medium;

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }

    public enum Priority
    {
        Low = 0,
        Medium = 1,
        High = 2
    }
}
