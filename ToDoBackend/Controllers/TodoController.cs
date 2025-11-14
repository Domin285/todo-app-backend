using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoBackend.Data;
using ToDoBackend.Models;
using ToDoBackend.Dtos;

namespace ToDoBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TodoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodos()
        {
            return await _context.TodoItems
           .OrderBy(t => t.Id)
           .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodo(int id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost]
        public async Task<ActionResult<TodoItem>> CreateTodo(CreateTodoDto dto)
        {
            var item = new TodoItem
            {
                Title = dto.Title,
                Description = dto.Description,
                IsDone = dto.IsDone,
                CreatedAt = DateTime.UtcNow
            };

            _context.TodoItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTodo), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodo(int id, UpdateTodoDto dto)
        {
            var existing = await _context.TodoItems.FindAsync(id);
            if (existing == null) return NotFound();

            existing.Title = dto.Title;
            existing.Description = dto.Description;
            existing.IsDone = dto.IsDone;

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
