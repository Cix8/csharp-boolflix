using csharp_boolflix.Models;

namespace csharp_boolflix.Builders
{
    public class GenresBuilder
    {
        public Genre NewGenre { get; set; }
        public List<Genre> Genres { get; set; }

        public GenresBuilder()
        {
            Genres = new List<Genre>();
            NewGenre = new Genre();
        }
    }
}
