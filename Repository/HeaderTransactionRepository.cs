using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokopediaMain.Repository
{
    public class HeaderTransactionRepository
    {
        private static MyDatabaseEntities1 db = DBSingleton.getData();
        internal static HeaderTransaction getDataByID(int currentID)
        {
            HeaderTransaction header = db.HeaderTransactions.Where(x => x.UserID == currentID).FirstOrDefault();
            return header;
        }

    }
}