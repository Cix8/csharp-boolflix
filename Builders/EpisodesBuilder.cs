using csharp_boolflix.Models;

namespace csharp_boolflix.Builders
{
    public class EpisodesBuilder
    {
        public Episode NewEpisode { get; set; }
        public List<Episode> Episodes { get; set; }
        public TVSeries Series { get; set; }

        public EpisodesBuilder()
        {
            NewEpisode = new Episode();
            Episodes = new List<Episode>();
            Series = new TVSeries();
        }
    }
}
