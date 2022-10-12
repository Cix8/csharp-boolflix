using csharp_boolflix.Builders.AbstractBuilders;
using csharp_boolflix.Models;

namespace csharp_boolflix.Builders
{
    public class TVSeriesBuilder : MediaBuilder
    {
        public TVSeries NewSeries { get; set; }
        public List<TVSeries> Series { get; set; }
        public TVSeriesBuilder()
        {
            NewSeries = new TVSeries();
            NewMediaInfo = new MediaInfo();
            Series = new List<TVSeries>();
            Actors = new List<Actor>();
            Genres = new List<Genre>();
            Features = new List<Feature>();
            Classifications = new List<Classification>();
        }
    }
}
