namespace csharp_boolflix.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public List<MediaInfo>? MediaInfos { get; set; }
        public Actor()
        {

        }
    }
}
