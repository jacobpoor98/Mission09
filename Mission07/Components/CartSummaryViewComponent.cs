using System;
using Microsoft.AspNetCore.Mvc;
using Mission07.Models;

namespace Mission07.Components
{
    // add a cart summary in the top right corner of the screen 
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket cart;
        public CartSummaryViewComponent(Basket cartservice)
        {
            cart = cartservice;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
