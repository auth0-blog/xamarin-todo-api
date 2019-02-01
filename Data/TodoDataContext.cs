using Microsoft.EntityFrameworkCore;

namespace auth0_todo_api.Data
{
  public class TodoDataContext : DbContext
  {
    public DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
      => builder.UseNpgsql("Host=localhost;Database=todo_db;Username=todo_db;Password=password;");
  }
}