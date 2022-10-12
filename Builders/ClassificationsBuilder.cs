using csharp_boolflix.Models;

namespace csharp_boolflix.Builders
{
    public class ClassificationsBuilder
    {
        public Classification NewClassification { get; set; }
        public List<Classification> Classifications { get; set; }

        public ClassificationsBuilder()
        {
            NewClassification = new Classification();
            Classifications = new List<Classification>();
        }
    }
}
