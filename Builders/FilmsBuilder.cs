using csharp_boolflix.Models;

namespace csharp_boolflix.Builders
{
    public class FilmsBuilder
    {
        public Film NewFilm { get; set; }
        public MediaInfo NewMediaInfo { get; set; }
        public List<Film> Films { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Feature> Features { get; set; }
        public List<Classification> Classifications { get; set; }
        public List<int> selectedActors { get; set; }
        public List<int> selectedFeatures { get; set; }
        public List<int> selectedGenres { get; set; }

        public FilmsBuilder()
        {
            NewFilm = new Film();
            NewMediaInfo = new MediaInfo();
            Films = new List<Film>();
            Actors = new List<Actor>();
            Genres = new List<Genre>();
            Features = new List<Feature>();
            Classifications = new List<Classification>();
        }
    }
}
