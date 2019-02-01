using System.ComponentModel.DataAnnotations.Schema;

namespace auth0_todo_api.Data
{
  public class TodoItem
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsDone { get; set; } 
  }
}