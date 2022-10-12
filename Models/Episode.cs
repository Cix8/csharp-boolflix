using csharp_boolflix.SuperClasses;

namespace csharp_boolflix.Models
{
    public class Episode : Media 
    {
        public int DurationInMinutes { get; set; }
        public int Season { get; set; }
        public int TVSeriesId { get; set; }
        public TVSeries? TVSeries { get; set; }
        public Episode()
        {
            this.ViewsCounter = 0;
        }
    }
}
