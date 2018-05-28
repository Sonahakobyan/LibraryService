using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;


namespace LibraryService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class LibraryService : ILibraryService
    {
        private int currID = 0;
        private List<Book> books = new List<Book>();

        int? ILibraryService.AddBook(Book book)
        {
            if (book.IsValid())
            {
                book.ID = ++currID;
                books.Add(book);

                return book.ID;
            }
            return null;
        }
        
        List<Book> ILibraryService.GetAllBooks()
        {
            return books;
        }

        bool ILibraryService.UpdatePrice(Book book, double price)
        {
            Book found = books.Where(x => x.ID == book.ID).FirstOrDefault<Book>();
            if (found != null)
            {
                found.Price = price;
                
                return true;
            }
            return false;
        }
    }
}
