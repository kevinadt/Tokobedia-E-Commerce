using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TokopediaMain.View
{
    public partial class Insert_Product_Type : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
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

        protected void InputData_Click(object sender, EventArgs e)
        {
            String productType = txtProductType.Text;
            String description = txtDescription.Text;

            string temp = Repository.ProductTypeRepository.findProductTypeNamebyName(productType);

            if (temp == null)
            {
                TokopediaMain.Repository.ProductTypeRepository.Create(productType, description);

                Response.Redirect("./View Product Type.aspx");
            }else
            {
                Util.PageUtililty.ErrorMessage(this,"Product Name sudah terdaftar");
            }

            
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx");
        }
    }
}