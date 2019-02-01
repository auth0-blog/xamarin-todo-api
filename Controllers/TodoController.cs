using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace auth0_todo_api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TodoController : ControllerBase
  {
    [HttpGet]
    public Task<List<string>> Get()
    {
      return Task.FromResult(new List<string> {
        "Hello",
        "World"
      });
    }
  }
}