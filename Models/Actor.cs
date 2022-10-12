using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome è obbligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il cognome è obbligatorio")]
        public string Lastname { get; set; }
        public List<MediaInfo>? MediaInfos { get; set; }
        public Actor()
        {

        }
    }
}
