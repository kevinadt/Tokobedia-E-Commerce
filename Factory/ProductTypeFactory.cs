using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokopediaMain.Factory
{
    public class ProductTypeFactory
    {

        public static ProductType CreateProduct(String productType, String productDescription)
        {

            return new ProductType()
            {
                Name = productType,
                Description = productDescription
            };
        }

    }
}