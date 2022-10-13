using csharp_boolflix.Models;

namespace csharp_boolflix.GuestUtility
{
    public class IndexUtility
    {
        public List<Film> Films { get; set; }
        public List<TVSeries> TVSeries { get; set; }

        public IndexUtility()
        {
            Films = new List<Film>();
            TVSeries = new List<TVSeries>();
        }
    }
}
