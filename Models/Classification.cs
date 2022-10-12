using csharp_boolflix.CustomValidations;
using csharp_boolflix.SuperClasses;
using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Classification
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "L'età della classificazione è obbligatoria")]
        [ClassificationValidation]
        public int Age { get; set; }
        public List<Film>? Films { get; set; }
        public List<TVSeries>? TVSeries { get; set; }

        public Classification()
        {

        }
    }
}
