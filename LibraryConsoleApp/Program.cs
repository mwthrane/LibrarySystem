using LibrarySystem;

internal class Program
{
    private static void Main(string[] args)
    {
        Book[] books = new Book[3];

        books[0] = new Book("Harry Potter & The Goblet of Fire", "J.K. Rowling", "2000", "074754624X");
        books[1] = new Book("Harry Potter & The Book of Secrets", "J.K. Rowling", "1998", "074754534X");
        books[2] = new Book("Harry Potter & The Half-Blood Price", "J.K. Rowling", "1997", "0747543424X");

       foreach (Book book in books)
        {
            string bookInfo = book.DisplayBookInfo();
            Console.WriteLine(bookInfo);
        }


    }
}