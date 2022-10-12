using csharp_boolflix.Builders;
using csharp_boolflix.Context;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class EditorController : Controller
    {
        private MyContext _db;

        public EditorController()
        {
            _db = new MyContext();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Actors()
        {
            ActorsBuilder actorsBuilder = new ActorsBuilder();
            actorsBuilder.Actors = _db.Actors.ToList();
            return View(actorsBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateActor(ActorsBuilder formData)
        {
            if(!ModelState.IsValid)
            {
                formData.Actors = _db.Actors.ToList();
                return View("Actors", formData);
            }
            _db.Actors.Add(formData.NewActor);
            _db.SaveChanges();
            return RedirectToAction("Actors");
        }
    }
}
