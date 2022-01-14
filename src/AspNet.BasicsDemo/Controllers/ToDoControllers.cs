namespace AspNet.BasicsDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoControllers : ControllerBase
{
    [HttpGet("{a:int}/{b:int}")]
    public int Add(int a, int b)
    {
        return a + b;
    }
}