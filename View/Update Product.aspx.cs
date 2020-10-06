using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TokopediaMain.View
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            checkUser();
            if (!this.IsPostBack)
            {
                String id = Request.QueryString["id"];
                txtData.Text = "ID yang ingin diubah: " + id;
                loadData(id);
                load_DropDownList();
            }
        }

        private void loadData(string id)
        {
            int currentID = Int32.Parse(id);
            Product product = Repository.ProductRepository.getDataByID(currentID);

            string TypeName = Repository.ProductTypeRepository.findProductTypeNamebyID(product.ProductTypeID);

            txtProductName.Text = product.Name;
            txtProductPrice.Text = product.Price.ToString();
            txtProductStock.Text = product.Stock.ToString();
            DropListType.SelectedValue = TypeName;
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


        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(txtProductPrice.Text);

            if (price % 1000 == 0)
            {
                String id = Request.QueryString["id"];
                String productName = txtProductName.Text;
                String productPrice = txtProductPrice.Text;
                String productStock = txtProductStock.Text;
                String productType = DropListType.SelectedItem.Text;

                int productTypeID = Repository.ProductTypeRepository.findProductTypeID(productType);

                TokopediaMain.Repository.ProductRepository.Update(id, productName, productPrice, productStock, productTypeID);

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
    }
}