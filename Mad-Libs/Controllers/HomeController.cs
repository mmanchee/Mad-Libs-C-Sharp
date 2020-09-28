using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/form")]
    // public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLib(string noun, string exclamation, string verb, string name, string dog, string monster)
    {
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.Exclamation = exclamation;
      myWordVariable.Verb = verb;
      myWordVariable.Name = name;
      myWordVariable.Dog = dog;
      myWordVariable.Noun = noun;
      myWordVariable.Monster = monster;
      return View(myWordVariable);
    }



  }
}