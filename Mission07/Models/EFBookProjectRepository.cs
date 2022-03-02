using System;
using System.Linq;

namespace Mission07.Models
{
    // connects the IBookProjectRepository with the EFBookProjectRepository
    public class EFBookProjectRepository : IBookProjectRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookProjectRepository (BookstoreContext temp)
        {
            context = temp;
        }
        // make it queryable
        public IQueryable<Book> Books => context.Books;
    }
}
