using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission07.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission07.Controllers
{
    public class PurchaseController : Controller
    {
        // initialize the IPurchaseRepository and Basket
        private IPurchaseRepository repo { get; set; }
        private Basket basket { get; set; }

        public PurchaseController(IPurchaseRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        // get method for a new purchase
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }

        // post method for the purchase
        [HttpPost]
        public IActionResult Checkout(Purchase purchase)
        {
            // throw error if they have no items in the cart
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            // if the cart is valid, save the purchase to the purchases table and
            // redirect them to the PurchaseCompleted page
            if (ModelState.IsValid)
            {
                purchase.Lines = basket.Items.ToArray();
                repo.SavePurchase(purchase);
                basket.ClearBasket();

                return RedirectToPage("/PurchaseCompleted");
            }
            // else take them to the home page
            else
            {
                return View();
            }
        }
    }
}
