using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome del genere è obbligatorio")]
        public string Name { get; set; }
        public List<MediaInfo>? MediaInfos { get; set; }
        public Genre()
        {

        }
    }
}
