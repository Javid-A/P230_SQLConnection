namespace P230_SQLConnection.Entities
{
    public class BlogTags
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int TagId { get; set; }
        public Blog Blog { get; set; }
        public Tag Tag { get; set; }

        public BlogTags()
        {
            Tag = new();
            Blog = new();
        }
    }

    
}
