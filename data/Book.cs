namespace BlogBookApp.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? Description { get; set; }
        public List<string>? Pages { get; set; }
    }
}