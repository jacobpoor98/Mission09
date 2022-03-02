using System;
using System.Linq;

namespace Mission07.Models.ViewModels
{
    // reference both the page info page and the Books page
    public class BooksViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
