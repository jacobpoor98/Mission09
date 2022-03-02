using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Mission07.Models
{
    public class Purchase
    {
        // creates the table for Purchases using PurchaseId as the primary key
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        // also includes error messages if user doesn't enter anything
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an Address Line 1")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }

        public int Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country")]
        public string Country { get; set; }
    }
}
