namespace ToDoBackend.Dtos
{
    public class CreateTodoDto
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
