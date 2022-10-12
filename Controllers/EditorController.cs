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

        public IActionResult Genres()
        {
            GenresBuilder genresBuilder = new GenresBuilder();
            genresBuilder.Genres = _db.Genres.ToList();
            return View(genresBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateGenre(GenresBuilder formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Genres = _db.Genres.ToList();
                return View("Genres", formData);
            }
            _db.Genres.Add(formData.NewGenre);
            _db.SaveChanges();
            return RedirectToAction("Genres");
        }

        public IActionResult Classifications()
        {
            ClassificationsBuilder pegisBuilder = new ClassificationsBuilder();
            pegisBuilder.Classifications = _db.Classifications.ToList();
            return View(pegisBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateClassification(ClassificationsBuilder formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Classifications = _db.Classifications.ToList();
                return View("Classifications", formData);
            }
            _db.Classifications.Add(formData.NewClassification);
            _db.SaveChanges();
            return RedirectToAction("Classifications");
        }

        public IActionResult Features()
        {
            FeaturesBuilder featuresBuilder = new FeaturesBuilder();
            featuresBuilder.Features = _db.Features.ToList();
            return View(featuresBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFeature(FeaturesBuilder formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Features = _db.Features.ToList();
                return View("Features", formData);
            }
            _db.Features.Add(formData.NewFeature);
            _db.SaveChanges();
            return RedirectToAction("Features");
        }
    }
}
