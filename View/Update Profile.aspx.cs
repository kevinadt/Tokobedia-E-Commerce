using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokopediaMain.Repository;

namespace TokopediaMain.View
{
    public partial class Update_Profile : System.Web.UI.Page
    {

        static string emailDefault;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("./Home.aspx");
            }
            if (!this.IsPostBack)
            {
                loadData();
            }
        }

        private void loadData()
        {
            emailDefault = Session["UserName"].ToString();
            txtEmail.Text = Session["UserName"].ToString();
            txtName.Text = Session["Name"].ToString();
            txtGender.SelectedValue = Session["Gender"].ToString();
        }

        protected void Update_Clicked(object sender, EventArgs e)
        {
            string currentId = Session["UserID"].ToString();
            int id = Int32.Parse(currentId);
            string name = txtName.Text;
            string gender = txtGender.SelectedValue.ToString();
            string email = txtEmail.Text;
            //txtID.Text = name + gender + email;

            if(email == emailDefault)
            {
                updateBio(id, email, name, gender);
            }
            else if (TokopediaMain.Repository.UserRepository.checkUserMail(email)==null)
            {
                updateBio(id, email, name, gender);
            }
            else
            {
                Util.PageUtililty.ErrorMessage(this, "Email sudah terdaftar.");
            }
            
        }

        private void updateBio(int id, string email, string name, string gender)
        {
            TokopediaMain.Repository.UserRepository.UpdateProfile(id, email, name, gender);
            Session["UserName"] = email;
            Session["Name"] = name;
            Session["Gender"] = gender;
            Response.Redirect("./Profile.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx");
        }
    }
}