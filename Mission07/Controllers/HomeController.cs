using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission07.Models;
using Mission07.Models.ViewModels;

namespace Mission07.Controllers
{
    public class HomeController : Controller
    {
        private IBookProjectRepository repo;

        public HomeController(IBookProjectRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string bookCat, int pageNum = 1)
        {
            int pageSize = 10;

            // gather the info needed for the page info page and send it off
            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(p => p.Category == bookCat || bookCat == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks =
                        (bookCat == null
                            ? repo.Books.Count()
                            : repo.Books.Where(x => x.Category == bookCat).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
    }
}
