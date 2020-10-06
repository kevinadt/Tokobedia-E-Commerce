using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokopediaMain;

namespace TokopediaMain.Repository
{

    public class UserRepository
    {
        private static MyDatabaseEntities1 db = DBSingleton.getData();

        public static User checkUser(string email, string password)
        {
            return db.Users.Where(user => user.Email.Equals(email) && user.Password.Equals(password)).FirstOrDefault();
        }

        internal static List<User> getData()
        {
            return db.Users.ToList();
        }

        public static User getUserID(int id)
        {
            User users = db.Users.Where(user => user.ID == id).FirstOrDefault();
            return users;
        }

        internal static void UpdateHakAkses(int id, string roleId, string userStatus)
        {
            int userId = id;
            User user = db.Users.Where(users => users.ID == userId).FirstOrDefault();
            user.RoleID = Int32.Parse(roleId);
            user.Status = userStatus;

            db.SaveChanges();
        }

        internal static User checkUserMail(string email)
        {
            return db.Users.Where(user => user.Email.Equals(email)).FirstOrDefault();
        }

        internal static void UpdateProfile(int userId, string email, string name, string gender)
        {
            User user = db.Users.Where(users => users.ID == userId).FirstOrDefault();
            user.Email = email;
            user.Name = name;
            user.Gender = gender;

            db.SaveChanges();
        }

        internal static void updatePassword(int userId, string newPassword)
        {
            User user = db.Users.Where(users => users.ID == userId).FirstOrDefault();
            user.Password = newPassword;

            db.SaveChanges();
        }

        internal static void Delete(int id)
        {
            User user = db.Users.Where(users => users.ID == id).FirstOrDefault();
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}