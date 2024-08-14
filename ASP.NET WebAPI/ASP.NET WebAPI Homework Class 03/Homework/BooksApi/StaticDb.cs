using BooksApi.Models;

namespace BooksApi
{
    public static class StaticDb
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Author = "Jane Austen",
                Title = "Pride and Prejudice",
            },
              new Book()
            {
                Author = "Scott Fitzgerald",
                Title = "The Great Gatsby",
            },
                new Book()
            {
                Author = "Harper Lee",
                Title = "To Kill a Mockingbird",
            },
                  new Book()
            {
                Author = " Louisa May Alcott",
                Title = "Little Women",
            },
        };
    }
}
