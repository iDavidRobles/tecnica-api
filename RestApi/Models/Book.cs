namespace RestApi.Models
{
    public abstract class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }    
        public string ISBN { get; set; }
        public string summary { get; set; }
    }
}