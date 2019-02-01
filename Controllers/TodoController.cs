using System.Collections.Generic;
using System.Threading.Tasks;
using auth0_todo_api.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace auth0_todo_api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TodoController : ControllerBase
  {
    private readonly TodoDataContext dataContext;

    public TodoController(TodoDataContext context)
    {
      this.dataContext = context;
    }

    public List<TodoItem> Get()
    {
      return dataContext.TodoItems.ToList();
    }

    [HttpPost]
    public async Task AddItem(TodoItem item)
    {
      await dataContext.TodoItems.AddAsync(item);
      await dataContext.SaveChangesAsync();
    }
  }
}
