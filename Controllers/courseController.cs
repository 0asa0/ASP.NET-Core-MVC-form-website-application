using Microsoft.AspNetCore.Mvc;
using proje1.Models;

namespace proje1.Controllers
{
    public class courseController: Controller
    {
        public IActionResult Indexx()
        {
            var model = Repository1.Apps;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository1.Apps.Any(x => x.email.Equals(model.email)))
            {
                ModelState.AddModelError("email", "This email address is already in use");
            }
            

            if (ModelState.IsValid)
            {
            Repository1.AddApplication(model);
            return View("feedback",model);
            }
            return View(model);
        }
    }
}