namespace domain
{
    public class Article
    {
         public int ArticleCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Brand ArticleBrand { get; set; }
        public Category ArticleCategory { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
    }
}
