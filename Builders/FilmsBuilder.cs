using csharp_boolflix.Builders.AbstractBuilders;
using csharp_boolflix.Models;

namespace csharp_boolflix.Builders
{
    public class FilmsBuilder : MediaBuilder
    {
        public Film NewFilm { get; set; }
        public List<Film> Films { get; set; }
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
