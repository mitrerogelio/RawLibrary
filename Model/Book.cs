namespace RawLibrary.Model;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string ISBN { get; set; }
    public string Genre { get; set; }
    
    public List<Book> Books { get; } = [];

}