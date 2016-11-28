using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [Route("home/index")]
    public IActionResult Index() => Ok("Hello World from a controller");

    [Route("home/index/view")]
    public IActionResult IndexWithView() => View();

    [Route("home/index/view/greet/{username?}")]
    public IActionResult IndexWithViewGreeting(string username = "you")=>View(new Greeting(){Username=username});

    [Route("home/greet/{username}")]
    public IActionResult Greet(string username)
    {
        var greeting = new Greeting { Username = username };
        return Ok(greeting);
    }
}