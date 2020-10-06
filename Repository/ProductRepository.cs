using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokopediaMain.Factory;

namespace TokopediaMain.Repository
{
    public class ProductRepository
    {
        private static MyDatabaseEntities1 db = DBSingleton.getData();
        public static void Create(String productName, String productPrice, String productStock, int productTypeID)
        {

            Product product = ProductFactory.CreateProduct(productName, productStock, productPrice, productTypeID);
            db.Products.Add(product);
            db.SaveChanges();
        }

        public static List<Product> getData()
        {
            return db.Products.ToList();
        }

        internal static void Update(String id, String productName, String productPrice, String productStock, int productTypeID)
        {
            int productId = Int32.Parse(id);
            Product product = db.Products.Where(x => x.ID == productId).FirstOrDefault();
            product.Name = productName;
            product.Price = Int32.Parse(productPrice);
            product.Stock = Int32.Parse(productStock);
            product.ProductTypeID = productTypeID;
            db.SaveChanges();
        }

        internal static Product getDataByID(int currentID)
        {
            Product products = db.Products.Where(product => product.ID == currentID).FirstOrDefault();
            return products;
        }

        internal static void Delete(int id)
        {
            Product products = db.Products.Where(product => product.ID == id).FirstOrDefault();
            db.Products.Remove(products);
            db.SaveChanges();
        }

        internal static Product searchProductTypeID(int currentId)
        {
            Product products = db.Products.Where(product => product.ProductTypeID == currentId).FirstOrDefault();
            return products;
        }
    }
}