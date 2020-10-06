using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TokopediaMain.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("./Home.aspx");
            }
            else
            {
                load_data();
            }

        }

        private void load_data()
        {
            string currentId = Session["UserID"].ToString();
            int id = Int32.Parse(currentId);

            User user = Repository.UserRepository.getUserID(id);

            txtEmail.Text = user.Email;
            txtGender.Text = user.Gender;
            txtName.Text = user.Name;
            txtNameProfile.Text = user.Name;
            txtProfileID.Text = user.ID.ToString();

        }

        protected void btnUpdate_Clicked(object sender, EventArgs e)
        {
            Response.Redirect("./Update Profile.aspx");
        }

        protected void changeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Change Password.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx");
        }
    }
}