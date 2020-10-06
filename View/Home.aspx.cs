using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokopediaMain.Repository;

namespace TokopediaMain.View
{
    public partial class Home1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Load_ProductList();

            if (Session["UserName"] != null)
            {
                userNameLbl.Text = Session["UserName"].ToString();
            }
            else
            {
                btnLogOut.Visible = false;
                btnViewProfile.Visible = false;
                btnViewUser.Visible = false;
                btnInsertProduct.Visible = false;
                btnUpdateProduct.Visible = false;
                btnViewProductType.Visible = false;
                btnInsertProductType.Visible = false;
                btnUpdateProductType.Visible = false;
            }

            if (userNameLbl.Text != "guest")
            {
                btnLogIn.Visible = false;
                btnLogOut.Visible = true;
                btnViewProfile.Visible = true;

                //String RoleID = Session["RoleID"].ToString().Trim();

                if (Session["RoleID"].ToString().Equals("1"))
                {

                    buttonControl(true);

                    //btnViewUser.Visible = true;
                    //btnInsertProduct.Visible = true;
                    //btnUpdateProduct.Visible = true;
                    //btnViewProductType.Visible = true;
                    //btnInsertProductType.Visible = true;
                    //btnUpdateProductType.Visible = true;
                }
                else if (Session["RoleID"].ToString().Equals("2"))
                {
                    buttonControl(false);

                    //btnViewUser.Visible = false;
                    //btnInsertProduct.Visible = false;
                    //btnUpdateProduct.Visible = false;
                    //btnViewProductType.Visible = false;
                    //btnInsertProductType.Visible = false;
                    //btnUpdateProductType.Visible = false;
                }
            }

        }

        private void Load_ProductList()
        {
            List<Product> productList = ProductRepository.getData();

            Random random = new Random();

            int[] temp = new int[productList.Count];

            for (int a = 0; a < productList.Count; a++)
            {
                temp[a] = 0;
            }

            int count = 0;
            while (count != 5)
            {
                int num = random.Next(productList.Count);
                if (temp[num].Equals(0))
                {
                    temp[num] = 1;
                    count++;

                    TableRow newRow = new TableRow();
                    ProductList.Controls.Add(newRow);

                    TableCell ProductNameCell = new TableCell();
                    ProductNameCell.Controls.Add(new Label()
                    {
                        Text = productList.ElementAt(num).Name.ToString()
                    });
                    newRow.Cells.Add(ProductNameCell);

                    TableCell ProductPriceCell = new TableCell();
                    ProductPriceCell.Controls.Add(new Label()
                    {
                        Text = productList.ElementAt(num).Price.ToString()
                    });
                    newRow.Cells.Add(ProductPriceCell);

                    TableCell ProductStockCell = new TableCell();
                    ProductStockCell.Controls.Add(new Label()
                    {
                        Text = productList.ElementAt(num).Stock.ToString()
                    });
                    newRow.Cells.Add(ProductStockCell);

                }
            }

            //for (int i = 0; i < productList.Count; i++)
            //{
            //    TableRow newRow = new TableRow();
            //    ProductList.Controls.Add(newRow);

            //    TableCell ProductNameCell = new TableCell();
            //    ProductNameCell.Controls.Add(new Label()
            //    {
            //        Text = productList.ElementAt(i).Name.ToString()
            //    });
            //    newRow.Cells.Add(ProductNameCell);

            //    TableCell ProductPriceCell = new TableCell();
            //    ProductPriceCell.Controls.Add(new Label()
            //    {
            //        Text = productList.ElementAt(i).Price.ToString()
            //    });
            //    newRow.Cells.Add(ProductPriceCell);

            //    TableCell ProductStockCell = new TableCell();
            //    ProductStockCell.Controls.Add(new Label()
            //    {
            //        Text = productList.ElementAt(i).Stock.ToString()
            //    });
            //    newRow.Cells.Add(ProductStockCell);
            //}
        }

        private void buttonControl(bool type)
        {
            btnViewUser.Visible = type;
            btnInsertProduct.Visible = type;
            btnUpdateProduct.Visible = type;
            btnViewProductType.Visible = type;
            btnInsertProductType.Visible = type;
            btnUpdateProductType.Visible = type;
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Log In.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
            Session.RemoveAll();
            Response.Redirect("./Home.aspx");
            //Response.reload
        }

        protected void ViewProduct_Clicked(object sender, EventArgs e)
        {
            Response.Redirect("./View Product.aspx");
        }

        protected void btnInsertProduct_click(object sender, EventArgs e)
        {
            Response.Redirect("./Insert Product.aspx");
        }

        protected void updateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("./View Product.aspx");
        }

        protected void InsertProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Insert Product Type.aspx");
        }

        protected void ViewProductType_Click(object sender, EventArgs e)
        {
            Response.Redirect("./View Product Type.aspx");
        }

        protected void Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Profile.aspx");
        }

        protected void ViewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("./View User.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("./View Product Type.aspx");
        }
    }
}