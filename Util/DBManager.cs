using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TokopediaMain.Util
{
    public class DBManager
    {

        static SqlConnection connection = null;

        private DBManager()
        {

        }

        public static SqlConnection GetInstance()
        {
            if(DBManager.connection == null)
            {
                string attachDbFileName = @"'C:\Users\Aditya\Desktop\TM PSD\tokobedia\TokopediaMain\TokopediaMain\App_Data\MyDatabase.mdf'";

                DBManager.connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFileName=" + attachDbFileName + ";integrated Security=true");
            }

            return DBManager.connection;

        }


    }
}