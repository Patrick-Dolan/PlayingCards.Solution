using Microsoft.AspNetCore.Mvc;
using PlayingCards.Models;
using System;

namespace PlayingCards.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Deck newDeck = new Deck();
      return View(newDeck);
    }
  }
}