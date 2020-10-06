using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokopediaMain.Repository
{
    public class DetailTransactionRepository
    {

        private static MyDatabaseEntities1 db = DBSingleton.getData();

        internal static DetailTransaction getItemByID(int ID)
        {
            DetailTransaction detail = db.DetailTransactions.Where(x => x.ProductID == ID).FirstOrDefault();
            return detail;
        }



    }
}