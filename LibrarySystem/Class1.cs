namespace LibrarySystem
{
    public class Book(string title, string author, string publicationYear, string isbn)
    {
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public string PublicationYear { get; set; } = publicationYear;
        public string ISBN { get; set; } = isbn;

        public string DisplayBookInfo()
        {
            return $"Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}, ISBN: {ISBN}";
        }
    }
}
