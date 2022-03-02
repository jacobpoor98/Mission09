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

        public Basket basket { get; set; }

        public string ReturnUrl { get; set; }

        public PurchaseModel (IBookProjectRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public void OnGet(string returnUrl)
        {
            // take them back to the returnUrl if exists, else take them to the homepage
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            // add the book to the cart via the book Id
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket.AddItem(b, 1);

            // redirect back to the ReturnUrl
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
