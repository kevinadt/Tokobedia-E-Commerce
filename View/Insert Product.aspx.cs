using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokopediaMain.Repository;

namespace TokopediaMain.View
{
    public partial class Insert_Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                checkUser();
                load_DropDownList();
            }
        }

        private void load_DropDownList()
        {
            List<ProductType> productType = Repository.ProductTypeRepository.getData();
            string[] ListDataTypes = new string[productType.Count];

            for (int a = 0; a < productType.Count; a++)
            {
                ListDataTypes[a] = productType.ElementAt(a).Name.ToString();
            }
            DropListType.DataSource = ListDataTypes;
            DropListType.DataBind();
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
            int price = Convert.ToInt32(txtProductPrice.Text);

            if (price % 1000 == 0)
            {
                String productName = txtProductName.Text;
                String productPrice = txtProductPrice.Text;
                String productStock = txtProductStock.Text;
                String productType = DropListType.SelectedValue.ToString();
                //String productTypeID = txtType.SelectedItem.Text;
                //selectedValue.Text = productType;
                int productTypeID = Repository.ProductTypeRepository.findProductTypeID(productType);

                ProductRepository.Create(productName, productPrice, productStock, productTypeID);

                Response.Redirect("./View Product.aspx");
            }
            else
            {
                TokopediaMain.Util.PageUtililty.ErrorMessage(this, "Harga minimal 1000 dan kelipatannya");
            }

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx");
        }

        protected void DropListType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}