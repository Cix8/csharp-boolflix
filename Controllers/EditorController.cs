using csharp_boolflix.Builders;
using csharp_boolflix.Context;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Controllers
{
    [Authorize]
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
            return View("Actors/Create", actorsBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateActor(ActorsBuilder formData)
        {
            if(!ModelState.IsValid)
            {
                formData.Actors = _db.Actors.ToList();
                return View("Actors/Create", formData);
            }
            _db.Actors.Add(formData.NewActor);
            _db.SaveChanges();
            return RedirectToAction("Actors");
        }

        public IActionResult Genres()
        {
            GenresBuilder genresBuilder = new GenresBuilder();
            genresBuilder.Genres = _db.Genres.ToList();
            return View("Genres/Create", genresBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateGenre(GenresBuilder formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Genres = _db.Genres.ToList();
                return View("Genres/Create", formData);
            }
            _db.Genres.Add(formData.NewGenre);
            _db.SaveChanges();
            return RedirectToAction("Genres");
        }

        public IActionResult Classifications()
        {
            ClassificationsBuilder pegisBuilder = new ClassificationsBuilder();
            pegisBuilder.Classifications = _db.Classifications.OrderBy(c => c.Age).ToList();
            return View("Classifications/Create", pegisBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateClassification(ClassificationsBuilder formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Classifications = _db.Classifications.OrderBy(c => c.Age).ToList();
                return View("Classifications/Create", formData);
            }
            _db.Classifications.Add(formData.NewClassification);
            _db.SaveChanges();
            return RedirectToAction("Classifications");
        }

        public IActionResult Features()
        {
            FeaturesBuilder featuresBuilder = new FeaturesBuilder();
            featuresBuilder.Features = _db.Features.ToList();
            return View("Features/Create", featuresBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFeature(FeaturesBuilder formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Features = _db.Features.ToList();
                return View("Features/Create", formData);
            }
            _db.Features.Add(formData.NewFeature);
            _db.SaveChanges();
            return RedirectToAction("Features");
        }

        public IActionResult Films()
        {
            FilmsBuilder filmsBuilder = new FilmsBuilder();
            filmsBuilder.Films = _db.Films.ToList();
            filmsBuilder.Features = _db.Features.ToList();
            filmsBuilder.Actors = _db.Actors.ToList();
            filmsBuilder.Genres = _db.Genres.ToList();
            filmsBuilder.Classifications = _db.Classifications.ToList();
            return View("Films/Create", filmsBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFilm(FilmsBuilder formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Films = _db.Films.ToList();
                formData.Features = _db.Features.ToList();
                formData.Actors = _db.Actors.ToList();
                formData.Genres = _db.Genres.ToList();
                formData.Classifications = _db.Classifications.ToList();
                return View("Films/Create", formData);
            }
            _db.Films.Add(formData.NewFilm);
            _db.SaveChanges();
            formData.NewMediaInfo.Actors = _db.Actors.Where(act => formData.selectedActors.Contains(act.Id)).ToList();
            formData.NewMediaInfo.Features = _db.Features.Where(feat => formData.selectedFeatures.Contains(feat.Id)).ToList();
            formData.NewMediaInfo.Genres = _db.Genres.Where(gen => formData.selectedGenres.Contains(gen.Id)).ToList();
            Film storedFilm = _db.Films.Where(film => film.Title == formData.NewFilm.Title).First();
            formData.NewMediaInfo.FilmId = storedFilm.Id;
            _db.MediaInfos.Add(formData.NewMediaInfo);
            _db.SaveChanges();
            return RedirectToAction("Films");
        }

        public IActionResult TVSeries()
        {
            TVSeriesBuilder tvSeriesBuilder = new TVSeriesBuilder();
            tvSeriesBuilder.Series = _db.TVSeries.ToList();
            tvSeriesBuilder.Features = _db.Features.ToList();
            tvSeriesBuilder.Actors = _db.Actors.ToList();
            tvSeriesBuilder.Genres = _db.Genres.ToList();
            tvSeriesBuilder.Classifications = _db.Classifications.ToList();
            return View("TVSeries/Create", tvSeriesBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSeries(TVSeriesBuilder formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Series = _db.TVSeries.ToList();
                formData.Features = _db.Features.ToList();
                formData.Actors = _db.Actors.ToList();
                formData.Genres = _db.Genres.ToList();
                formData.Classifications = _db.Classifications.ToList();
                return View("TVSeries/Create", formData);
            }
            _db.TVSeries.Add(formData.NewSeries);
            _db.SaveChanges();
            formData.NewMediaInfo.Actors = _db.Actors.Where(act => formData.selectedActors.Contains(act.Id)).ToList();
            formData.NewMediaInfo.Features = _db.Features.Where(feat => formData.selectedFeatures.Contains(feat.Id)).ToList();
            formData.NewMediaInfo.Genres = _db.Genres.Where(gen => formData.selectedGenres.Contains(gen.Id)).ToList();
            TVSeries storedSeries = _db.TVSeries.Where(series => series.Title == formData.NewSeries.Title).First();
            formData.NewMediaInfo.TVSeriesId = storedSeries.Id;
            _db.MediaInfos.Add(formData.NewMediaInfo);
            _db.SaveChanges();
            return RedirectToAction("TVSeries");
        }

        public IActionResult Episodes(int id)
        {
            EpisodesBuilder episodesBuilder = new EpisodesBuilder();
            TVSeries series = _db.TVSeries.Where(series => series.Id == id).First();
            episodesBuilder.NewEpisode.TVSeries = series;
            episodesBuilder.Episodes = _db.Episodes.Where(ep => ep.TVSeriesId == series.Id).ToList();
            return View("Episodes/Create", episodesBuilder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEpisode(int id, EpisodesBuilder formData)
        {

            if (!ModelState.IsValid)
            {
                TVSeries series = _db.TVSeries.Where(series => series.Id == id).First();
                formData.NewEpisode.TVSeries = series;
                formData.Episodes = _db.Episodes.Where(ep => ep.TVSeriesId == series.Id).ToList();
                return View("Episodes/Create", formData);
            }

            formData.NewEpisode.TVSeriesId = id;
            _db.Episodes.Add(formData.NewEpisode);
            _db.SaveChanges();
            return RedirectToAction("Episodes", new {id = id});
        }
    }
}
