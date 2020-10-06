using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokopediaMain.Factory;

namespace TokopediaMain.Repository
{
    public class ProductTypeRepository
    {
        private static MyDatabaseEntities1 db = DBSingleton.getData();
        public static void Create(String productType, String productDescription)
        {
            ProductType product = ProductTypeFactory.CreateProduct(productType, productDescription);
            db.ProductTypes.Add(product);
            db.SaveChanges();
        }

        public static List<ProductType> getData()
        {
            return db.ProductTypes.ToList();
        }

        internal static void Update(string id, string productTypeName, string productTypeDescription)
        {
            int productTypeId = Int32.Parse(id);
            ProductType productType = db.ProductTypes.Where(x => x.ID == productTypeId).FirstOrDefault();
            productType.Name = productTypeName;
            productType.Description = productTypeDescription;

            db.SaveChanges();
        }
        
        internal static string findProductTypeNamebyName(string productType)
        {
            ProductType product = db.ProductTypes.Where(x => x.Name == productType).FirstOrDefault();
            if(product != null)
            {
                return product.Name;
            }else
            {
                return null;
            }
        }

        internal static void Delete(int currentId)
        {
            ProductType productsType = db.ProductTypes.Where(productType => productType.ID == currentId).FirstOrDefault();
            db.ProductTypes.Remove(productsType);

            db.SaveChanges();
        }

        internal static ProductType getDataByID(int id)
        {
            ProductType product = db.ProductTypes.Where(x => x.ID == id).FirstOrDefault();
            return product;
        }

        internal static int findProductTypeID(string temp)
        {
            ProductType product = db.ProductTypes.Where(x => x.Name.Equals(temp)).FirstOrDefault();
            return product.ID;
        }

        internal static string findProductTypeNamebyID(int id)
        {
            ProductType product = db.ProductTypes.Where(x => x.ID == id).FirstOrDefault();
            return product.Name;
        }
    }
}