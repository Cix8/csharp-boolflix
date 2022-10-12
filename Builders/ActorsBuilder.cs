using csharp_boolflix.Models;

namespace csharp_boolflix.Builders
{
    public class ActorsBuilder
    {
        public Actor NewActor { get; set; }
        public List<Actor> Actors { get; set; }

        public ActorsBuilder()
        {
            Actors = new List<Actor>();
            NewActor = new Actor();
        }
    }
}
