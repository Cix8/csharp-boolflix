using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.SuperClasses
{
    public abstract class Media
    {
        public int Id { get; set; }

        [Column(TypeName = "text")]
        public string Cover { get; set; }
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        public int ViewsCounter { get; set; }
    }
}
