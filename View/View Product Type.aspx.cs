using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokopediaMain.Repository;

namespace TokopediaMain.View
{
    public partial class View_Product_Type : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            Load_ProductType();
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

        private void Load_ProductType()
        {
            List<ProductType> productList = ProductTypeRepository.getData();

            for (int i = 0; i < productList.Count; i++)
            {
                TableRow newRow = new TableRow();
                ProductList.Controls.Add(newRow);

                TableCell ProductTypeIDCell = new TableCell();
                ProductTypeIDCell.Controls.Add(new Label()
                {
                    Text = productList.ElementAt(i).ID.ToString()
                });
                newRow.Cells.Add(ProductTypeIDCell);

                TableCell ProductTypeNameCell = new TableCell();
                ProductTypeNameCell.Controls.Add(new Label()
                {
                    Text = productList.ElementAt(i).Name.ToString()
                });
                newRow.Cells.Add(ProductTypeNameCell);

                TableCell ProductTypeDescriptionCell = new TableCell();
                ProductTypeDescriptionCell.Controls.Add(new Label()
                {
                    Text = productList.ElementAt(i).Description.ToString()
                });
                newRow.Cells.Add(ProductTypeDescriptionCell);

                TableCell UpdateButtonCell = new TableCell();
                Button updateButton = new Button()
                {
                    Text = productList.ElementAt(i).ID.ToString()
                };
                updateButton.Click += UpdateButton_Click;
                UpdateButtonCell.Controls.Add(updateButton);
                newRow.Cells.Add(UpdateButtonCell);

                TableCell deleteButtonCell = new TableCell();
                Button deleteButton = new Button()
                {
                    Text = productList.ElementAt(i).ID.ToString()
                };
                deleteButton.Click += DeleteButton_Click;
                deleteButtonCell.Controls.Add(deleteButton);
                newRow.Cells.Add(deleteButtonCell);

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = (sender as Button).Text;
            int currentId = Int32.Parse(id);

            if (TokopediaMain.Repository.ProductRepository.searchProductTypeID(currentId) == null)
            {
                TokopediaMain.Repository.ProductTypeRepository.Delete(currentId);
                Response.Redirect("./View Product Type.aspx");
            }
            else
            {
                ErrorMessage("Tipe Product ini terkonfigurasi dengan product lain.");
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string id = (sender as Button).Text;
            Response.Redirect(string.Format("~/View/Update Product Type.aspx?id={0}", id));
        }

        protected void InsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Insert Product Type.aspx");
        }

        protected void UpdateProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Update Product Type.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx");
        }

        private void ErrorMessage(String message)
        {
            TokopediaMain.Util.PageUtililty.ErrorMessage(this, message);
        }

    }
}