using System;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> products, Func<Product, bool> selctor)
        {
            foreach (Product prod in products)
            {
                if (selctor(prod))
                    yield return prod;
            }
        }
    }
}
