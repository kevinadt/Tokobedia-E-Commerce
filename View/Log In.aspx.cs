using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokopediaMain.Util;
using TokopediaMain.Repository;

namespace TokopediaMain.View
{
    public partial class Log_In : System.Web.UI.Page
    {

        static string email, password;

        protected void Page_Load(object sender, EventArgs e)
        {
            alert.Visible = false;
            if (Session["UserName"] != null)
            {
                ErrorMessage("Anda sudah log in.");

                Response.Redirect("./Home.aspx");


            }
            if (!IsPostBack)
            {
                if (email != null)
                {
                    loadData();
                }
            }
        }

        private void loadData()
        {
            txtEmail.Text = email;
            txtPassword.Text = password;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Register.aspx");
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            User LogIn = UserRepository.checkUser(txtEmail.Text, txtPassword.Text);
            if (LogIn != null && LogIn.Status.ToString().Equals("Blocked"))
            {
                ErrorMessage("Account blocked.");
            }
            else if (LogIn != null)
            {
                Session["UserID"] = LogIn.ID;
                Session["UserName"] = LogIn.Email;
                Session["Name"] = LogIn.Name;
                Session["Password"] = LogIn.Password;
                Session["RoleID"] = LogIn.RoleID;
                Session["Gender"] = LogIn.Gender;

                if (btnRememberMe.Checked)
                {
                    Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(1);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(1);
                    email = Session["UserName"].ToString();
                    password = Session["Password"].ToString();
                }
                else
                {
                    Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
                    email = null;
                    password = null;
                }
                Response.Cookies["UserName"].Value = txtEmail.Text;
                Response.Cookies["Password"].Value = txtPassword.Text;

                Response.Redirect("./Home.aspx");
            }
            else
            {
                ErrorMessage("Invalid username/password");
            }
        }

        private void ErrorMessage(String message)
        {
            TokopediaMain.Util.PageUtililty.ErrorMessage(this, message);
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}