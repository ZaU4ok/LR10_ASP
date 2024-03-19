using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LR10_ASP
{
    public class ConsultationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            var model = new ConsultationRegistrationViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(ConsultationRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
