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
    }
}
