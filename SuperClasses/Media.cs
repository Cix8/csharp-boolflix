namespace csharp_boolflix.SuperClasses
{
    public abstract class Media
    {
        public int Id { get; set; }
        public string Cover { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ViewsCounter { get; set; }
    }
}
