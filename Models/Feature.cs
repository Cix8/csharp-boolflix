using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Feature
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome della caratteristica è obbligatorio")]
        public string Name { get; set; }
        public List<MediaInfo>? MediaInfos { get; set; }
        public Feature()
        {

        }
    }
}
