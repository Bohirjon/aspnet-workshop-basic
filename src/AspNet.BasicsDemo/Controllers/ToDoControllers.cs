namespace AspNet.BasicsDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ToDoControllers : ControllerBase
{
    [HttpGet("{a:int}/{b:int}")]
    public int Add(int a, int b)
    {
        return a + b;
    }
}