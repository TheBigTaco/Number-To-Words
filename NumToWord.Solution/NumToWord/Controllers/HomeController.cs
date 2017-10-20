using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using NumToWord.Models;

namespace NumToWord.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/result")]
      public ActionResult Result()
      {
        try
        {
          Translator newTranslator = new Translator(Request.Form["user-input"]);
          string output = newTranslator.NumberConvert(newTranslator);
          return View("Result", output);
        }
        catch(Exception)
        {
          return View("Result", "I'm sorry I'm afraid I can't let you do that");
        }

      }
    }
}
