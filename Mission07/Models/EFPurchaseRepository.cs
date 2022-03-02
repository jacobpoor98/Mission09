using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mission07.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        // initialize the BookstoreContext file and the IPurchaseRepository
        private BookstoreContext context;

        public EFPurchaseRepository (BookstoreContext temp)
        {
            context = temp;
        }

        // make it queryable
        public IQueryable<Purchase> Purchases => context.Purchases.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SavePurchase(Purchase purchase)
        {
            // add a purchase if non exists
            context.AttachRange(purchase.Lines.Select(x => x.Book));

            if (purchase.PurchaseId == 0)
            {
                context.Purchases.Add(purchase);
            }

            context.SaveChanges();
        }
    }
}
