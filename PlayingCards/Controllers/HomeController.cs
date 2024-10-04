using Microsoft.AspNetCore.Mvc;

namespace PlayingCards.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}