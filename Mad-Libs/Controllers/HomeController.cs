using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult Form() { return View(); }


  }
}