using csharp_boolflix.Models;

namespace csharp_boolflix.Builders
{
    public class FeaturesBuilder
    {
        public Feature NewFeature { get; set; }
        public List<Feature> Features { get; set; }

        public FeaturesBuilder()
        {
            NewFeature = new Feature();
            Features = new List<Feature>();
        }
    }
}
