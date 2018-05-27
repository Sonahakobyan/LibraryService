using System;
using System.Collections.Generic;
using LibraryService;

namespace LibraryServiceClient
{
    class ClinetApp
    {
        static void Main(string[] args)
        {
            ILibraryService lc = new LibraryService.LibraryService();
            
            Book book1 = new Book("Erich Maria Remarque", "Arch of Triumph", 5000, 1945);
            Book book2 = new Book("Sir Arthur Conan Doyle", "Sherlock Holmes", 5700, 1887);

            lc.AddBook(book1);
            lc.AddBook(book2);

            lc.UpdatePrice(book1, 6000);

            List<Book> books = lc.GetAllBooks();
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            Console.Read();
        }
    }
}
