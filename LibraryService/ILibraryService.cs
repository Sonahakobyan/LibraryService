using System.Collections.Generic;
using System.ServiceModel;

namespace LibraryService
{
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        int? AddBook(Book book);
        bool UpdatePrice(Book book, double price);
        List<Book> GetAllBooks();
    }
}
