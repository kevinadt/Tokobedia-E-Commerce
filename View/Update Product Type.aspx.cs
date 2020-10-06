using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TokopediaMain.View
{
    public partial class UpdateType : System.Web.UI.Page
    {

        static string defaultName;

        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            if (!this.IsPostBack)
            {
                String id = Request.QueryString["id"];
                txtData.Text = "ID yang ingin diubah: " + id;
                loadData(id);

            }
        }

        private void checkUser()
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("./Home.aspx");
            }
            else if (Session["UserName"] != null && !Session["RoleID"].ToString().Equals("1"))
            {
                Response.Redirect("./Home.aspx");
            }
        }

        private void loadData(string id)
        {
            int currentId = Int32.Parse(id);
            ProductType productType = Repository.ProductTypeRepository.getDataByID(currentId);
            txtProductTypeName.Text = productType.Name.ToString();
            defaultName = txtProductTypeName.Text;
            txtDescription.Text = productType.Description.ToString();
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            String id = Request.QueryString["id"];
            String productTypeName = txtProductTypeName.Text;
            String productTypeDescription = txtDescription.Text;

            string temp = Repository.ProductTypeRepository.findProductTypeNamebyName(productTypeName);


            if(defaultName == productTypeName)
            {
                TokopediaMain.Repository.ProductTypeRepository.Update(id, productTypeName, productTypeDescription);

                Response.Redirect("./View Product Type.aspx");
            }
            else if (temp == null)
            {
                TokopediaMain.Repository.ProductTypeRepository.Update(id, productTypeName, productTypeDescription);

                Response.Redirect("./View Product Type.aspx");
            }
            else
            {
                Util.PageUtililty.ErrorMessage(this, "Product Name sudah terdaftar");
            }
            
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx");
        }
    }
}