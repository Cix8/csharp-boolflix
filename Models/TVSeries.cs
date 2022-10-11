using csharp_boolflix.SuperClasses;

namespace csharp_boolflix.Models
{
    public class TVSeries : Media
    {
        public int SeasonsCounter { get; set; }
        public List<Episode> Episodes { get; set; }
        public MediaInfo MediaInfo { get; set; }
        public int PegiId { get; set; }
        public Pegi Pegi { get; set; }
        public TVSeries()
        {

        }
    }
}
