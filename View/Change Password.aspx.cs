using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TokopediaMain.View
{
    public partial class Change_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdateClick(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string id = Session["UserID"].ToString();
            int currentId = Int32.Parse(id);

            User user = Repository.UserRepository.getUserID(currentId);
            if (!currentPassword.Equals(user.Password.ToString()))
            {
                ErrorMessage("Password lama anda salah.");
            }
            else
            {
                if (!newPassword.Equals(confirmPassword))
                {
                    ErrorMessage("Password baru tidak sama.");
                }
                else
                {
                    Repository.UserRepository.updatePassword(currentId, newPassword);
                    Response.Redirect("./Home.aspx");
                }
            }
        }

        private void ErrorMessage(String message)
        {
            TokopediaMain.Util.PageUtililty.ErrorMessage(this, message);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx");
        }
    }
}