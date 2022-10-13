using csharp_boolflix.Context;
using csharp_boolflix.GuestUtility;
using Microsoft.AspNetCore.Mvc;

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
    }
}
