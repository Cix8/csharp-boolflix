namespace csharp_boolflix.Models
{
    public class MediaInfo
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public string InputDate { get; set; }
        public bool IsNew { get; set; }
        public int VideoQuality { get; set; }
        public int? FilmId { get; set; }
        public Film? Film { get; set; }
        public int? TVSeriesId { get; set; }
        public TVSeries? TVSeries { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Feature> Features { get; set; }
        public MediaInfo()
        {
            this.InputDate = DateTime.Now.ToString("dd/MM/yyyy");
            Actors = new List<Actor>();
            Genres = new List<Genre>();
            Features = new List<Feature>();
        }
    }
}
