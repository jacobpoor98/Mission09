using System;
using System.Linq;

namespace Mission07.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchase { get; }

        void SavePurchase(Purchase purchase);
    }
}
