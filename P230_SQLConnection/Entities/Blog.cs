namespace P230_SQLConnection.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public List<BlogTags> BlogTags { get; set; }

        public Blog()
        {
            Category = new();
            BlogTags = new();
        }
    }
}
