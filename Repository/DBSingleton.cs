using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokopediaMain.Repository
{
    public class DBSingleton
    {
        private static MyDatabaseEntities1 db = null;

        public static MyDatabaseEntities1 getData()
        {
            if (db == null)
            {
                db = new MyDatabaseEntities1();
            }
            return db;
        }
    }
    
    
}