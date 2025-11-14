using Microsoft.EntityFrameworkCore;
using ToDoBackend.Models;

namespace ToDoBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems {  get; set; } = null!;
    }
}
