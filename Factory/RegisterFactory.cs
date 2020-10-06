using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokopediaMain.Factory
{
    public class RegisterFactory
    {

        public static User CreateUser(String email, String name, String password, String gender)
        {
            return new User()
            {
                Email = email,
                Name = name,
                Password = password,
                Gender = gender,
                RoleID = 2,
                Status = "Active"
            };
        }

    }
}