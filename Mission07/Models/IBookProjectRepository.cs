using System;
using System.Linq;

namespace Mission07.Models
{
    // creates the IBookProjectRepository and allows its contents to be queryable
    public interface IBookProjectRepository
    {
        IQueryable<Book> Books { get; }
    }
}
