using BizimBotanikApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BizimBotanikApp.Controls
{
    public class AnaController : Controller
    {
        public IActionResult Index()
        {
            
            //linq sorguları
            
            return View(Fabrika.Cicekler);
        }

        public IActionResult Listele()
        {
            return View();
        }

        public IActionResult Hakkinda()
        {
            return View();
        }
    }
}
