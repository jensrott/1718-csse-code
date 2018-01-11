using System;

namespace opdrachtweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            // Author werkt nog niet
            author.getAuthor();
            Book book = new Book("Harry Potter", author, 25, 40);
            book.print();
        }
    }
}
