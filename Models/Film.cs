using csharp_boolflix.SuperClasses;

namespace csharp_boolflix.Models
{
    public class Film : Media
    {
        public int DurationInMinutes { get; set; }
        public MediaInfo MediaInfo { get; set; }
        public int ClassificationId { get; set; }
        public Classification Classification { get; set; }
        public Film()
        {

        }
    }
}
