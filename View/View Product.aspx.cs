using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokopediaMain.Repository;

namespace TokopediaMain.View
{
    public partial class View_Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnInsert.Visible = false;
            AdminTable.Visible = false;
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString() == "1")
                {
                    btnInsert.Visible = true;
                    AdminTable.Visible = true;
                }
            }

            Load_ProductList();
        }

        private void Load_ProductList()
        {
            List<Product> productList = ProductRepository.getData();

            for (int i = 0; i < productList.Count; i++)
            {
                TableRow newRow = new TableRow();
                ProductList.Controls.Add(newRow);

                TableCell ProductIDCell = new TableCell();
                ProductIDCell.Controls.Add(new Label()
                {
                    Text = productList.ElementAt(i).ID.ToString()
                });
                newRow.Cells.Add(ProductIDCell);

                TableCell ProductNameCell = new TableCell();
                ProductNameCell.Controls.Add(new Label()
                {
                    Text = productList.ElementAt(i).Name.ToString()
                });
                newRow.Cells.Add(ProductNameCell);

                TableCell ProductStockCell = new TableCell();
                ProductStockCell.Controls.Add(new Label()
                {
                    Text = productList.ElementAt(i).Stock.ToString()
                });
                newRow.Cells.Add(ProductStockCell);

                TableCell ProductTypeCell = new TableCell();

                string temp = productList.ElementAt(i).ProductTypeID.ToString();
                int productTypeID = Int32.Parse(temp);

                temp = Repository.ProductTypeRepository.findProductTypeNamebyID(productTypeID);
                ProductTypeCell.Controls.Add(new Label()

                {
                    Text = temp
                });
                newRow.Cells.Add(ProductTypeCell);

                TableCell ProductPriceCell = new TableCell();
                ProductPriceCell.Controls.Add(new Label()
                {
                    Text = productList.ElementAt(i).Price.ToString()
                });
                newRow.Cells.Add(ProductPriceCell);
            }


            List<Product> functionAdmin = ProductRepository.getData();
            for (int i = 0; i < productList.Count; i++)
            {
                TableRow newRow = new TableRow();
                AdminTable.Controls.Add(newRow);

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

            String currentId = (sender as Button).Text;
            int id = Int32.Parse(currentId);
            if (TokopediaMain.Repository.DetailTransactionRepository.getItemByID(id) == null)
            {
                TokopediaMain.Repository.ProductRepository.Delete(id);
                Response.Redirect("./View Product.aspx");
            }
            else
            {
                ErrorMessage("Product ini sedang dibeli oleh orang lain.");
            }

        }

        protected void InsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Insert Product.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            string id = (sender as Button).Text;

            Response.Redirect(string.Format("~/View/Update Product.aspx?id={0}", id));
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