using System;
using System.Linq;

namespace Mission07.Models
{
    public interface IPurchaseRepository
    {
        // create a queryable purchase repository
        IQueryable<Purchase> Purchases { get; }

        // save the purchase
        void SavePurchase(Purchase purchase);
    }
}
