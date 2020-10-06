using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TokopediaMain.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                ErrorMessage("Anda sudah terdaftar.");

                Response.Redirect("./Home.aspx");

                txtEmail.Text = Session["UserName"].ToString();
                txtPassword.Text = Session["Password"].ToString();
            }
        }

        protected void btnRegister_Clicked(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                String email = txtEmail.Text;

                if (Repository.UserRepository.checkUserMail(email) == null)
                {
                    String name = txtName.Text;
                    String password = txtPassword.Text;
                    String gender = txtGender.SelectedItem.Text;

                    TokopediaMain.Repository.RegisterRepository.Create(email, name, password, gender);

                    Response.Redirect("./Home.aspx");
                }
                else
                {
                    TokopediaMain.Util.PageUtililty.ErrorMessage(this, "Email sudah terdaftar.");
                }


            }
            else
            {
                TokopediaMain.Util.PageUtililty.ErrorMessage(this, "Password yang anda masukkan tidak sama");
            }

        }
        private void ErrorMessage(String message)
        {
            TokopediaMain.Util.PageUtililty.ErrorMessage(this, message);
        }

        protected void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx");
        }
    }
}