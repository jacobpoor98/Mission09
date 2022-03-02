using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission07.Models;

namespace Mission07.Components
{
    public class CatViewComponent : ViewComponent
    {
        // bring in the IBookProjectRepository and assign to a instance of CatViewComponent
        private IBookProjectRepository repo { get; set; }

        public CatViewComponent (IBookProjectRepository temp)
        {
            repo = temp;
        }

        // query the data and return it in a ViewBag
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookCat"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }
}
