using csharp_boolflix.Context;
using csharp_boolflix.GuestUtility;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Controllers
{
    public class GuestController : Controller
    {
        private MyContext _db;

        public GuestController()
        {
            _db = new MyContext();
        }
        public IActionResult Index()
        {
            IndexUtility indexUtility = new IndexUtility();
            indexUtility.Films = _db.Films.ToList();
            indexUtility.TVSeries = _db.TVSeries.ToList();
            return View(indexUtility);
        }

        public IActionResult Episodes(int id)
        {
            TVSeries series = _db.TVSeries.Where(ser => ser.Id == id).Include("Episodes").First();
            return View(series);
        }
    }
}
