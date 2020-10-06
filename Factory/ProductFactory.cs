using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokopediaMain.Factory
{
    public class ProductFactory
    {

        public static Product CreateProduct(String productName, String productStock, String productPrice, int productTypeID)
        {
            return new Product()
            {
                Name = productName,
                Price = Int32.Parse(productPrice),
                Stock = Int32.Parse(productStock),
                ProductTypeID = productTypeID
            };
        }

    }
}