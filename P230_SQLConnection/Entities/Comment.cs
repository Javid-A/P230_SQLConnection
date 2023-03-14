namespace P230_SQLConnection.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; } 
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
