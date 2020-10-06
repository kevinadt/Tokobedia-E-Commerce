using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokopediaMain.Factory;

namespace TokopediaMain.Repository
{
    public class RegisterRepository
    {
        private static MyDatabaseEntities1 db = DBSingleton.getData();

        public static void Create(String email, string name, string password, string gender)
        {

            User user = RegisterFactory.CreateUser(email, name, password, gender);
            db.Users.Add(user);
            db.SaveChanges();
        }


    }
}