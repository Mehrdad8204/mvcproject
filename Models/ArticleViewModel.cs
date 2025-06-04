namespace mvcproject.Models
{
    public class ArticleViewModel
    {
        public List<Category>? Categories { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public int CategoryId { get; set; }
    }
}