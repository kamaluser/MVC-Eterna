using System;
using Microsoft.AspNetCore.Mvc;

namespace Eterna_Template.Controllers
{
	public class AboutController:Controller
	{
        public IActionResult Index()
        {
            return View();
        }
    }
}
