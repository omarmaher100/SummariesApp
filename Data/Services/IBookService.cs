using System.Collections.Generic;
using Summaries.Controllers;

namespace Summaries.Data
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        
    }
}