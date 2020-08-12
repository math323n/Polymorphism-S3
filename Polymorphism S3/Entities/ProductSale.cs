using System;
using System.Collections.Generic;

namespace Polymorphism_S3.Entities
{
    public class ProductSale: Sale
    {
        protected static Dictionary<Product, int> productQuantities = new Dictionary<Product, int>();

        public  ProductSale(Dictionary<Product, int> productQuantities, DateTime date, int employeeId)
            : base(date, employeeId)
        {
            ProductQuantities = productQuantities;
        }

        public Dictionary<Product, int> ProductQuantities
        {
            get
            {
                return productQuantities;
            }

            set
            {
                productQuantities = value;
            }
        }

        public static void Add(Product product, int quantity)
        {
            productQuantities.Add(product, quantity);
        }
    }
}