using csharp_boolflix.Models;

namespace csharp_boolflix.Builders.AbstractBuilders
{
    public abstract class MediaBuilder
    {
        public MediaInfo NewMediaInfo { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Feature> Features { get; set; }
        public List<Classification> Classifications { get; set; }
        public List<int> selectedActors { get; set; }
        public List<int> selectedFeatures { get; set; }
        public List<int> selectedGenres { get; set; }
    }
}
