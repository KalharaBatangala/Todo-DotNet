using System.ComponentModel.DataAnnotations;

namespace ToDoApp
{
    public class TodoItem
    {
        [Key] // This marks the Id property as the primary key in the database.
        public int Id { get; set; }

        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
