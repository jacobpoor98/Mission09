using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission07.Infrastructure;
using Mission07.Models;

namespace Mission07.Pages
{
    public class PurchaseModel : PageModel
    {
        // bring in the IBookProjectRepository and assign it to a variable to be
        // used as an instance in this class
        private IBookProjectRepository repo { get; set; }

        public PurchaseModel (IBookProjectRepository temp)
        {
            repo = temp;
        }

        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            // take them back to the returnUrl if exists, else take them to the homepage
            ReturnUrl = returnUrl ?? "/";
            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            // add the book to the cart via the book Id
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(b, 1);

            HttpContext.Session.SetJson("basket", basket);

            // redirect back to the ReturnUrl
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
