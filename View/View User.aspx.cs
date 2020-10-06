using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokopediaMain.Repository;

namespace TokopediaMain.View
{
    public partial class View_User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUser();
            load_User();
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

        private void load_User()
        {
            List<User> userList = UserRepository.getData();

            for (int i = 0; i < userList.Count; i++)
            {
                TableRow newRow = new TableRow();
                UserList.Controls.Add(newRow);

                TableCell IDCell = new TableCell();
                IDCell.Controls.Add(new Label()
                {
                    Text = userList.ElementAt(i).ID.ToString()
                });
                newRow.Cells.Add(IDCell);

                TableCell NameCell = new TableCell();
                NameCell.Controls.Add(new Label()
                {
                    Text = userList.ElementAt(i).Name.ToString()
                });
                newRow.Cells.Add(NameCell);

                TableCell EmailCell = new TableCell();
                EmailCell.Controls.Add(new Label()
                {
                    Text = userList.ElementAt(i).Email.ToString()
                });
                newRow.Cells.Add(EmailCell);

                String status = "User";
                if (!userList.ElementAt(i).RoleID.ToString().Equals("2"))
                {
                    status = "Admin";
                }

                TableCell RoleIDCell = new TableCell();
                RoleIDCell.Controls.Add(new Label()
                {
                    Text = status
                });
                newRow.Cells.Add(RoleIDCell);

                TableCell StatusCell = new TableCell();
                StatusCell.Controls.Add(new Label()
                {
                    Text = userList.ElementAt(i).Status.ToString()
                });
                newRow.Cells.Add(StatusCell);

                TableCell UpdateButtonCell = new TableCell();
                Button updateButton = new Button()
                {
                    Text = userList.ElementAt(i).ID.ToString()
                };
                updateButton.Click += UpdateButton_Click;
                UpdateButtonCell.Controls.Add(updateButton);
                newRow.Cells.Add(UpdateButtonCell);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse((sender as Button).Text);
            User user = UserRepository.getUserID(ID);

            txtUserId.Text = ID.ToString();
            txtUserRole.Text = user.RoleID.ToString();
            txtStatus.SelectedValue = user.Status.ToString();
            //txtUserStatus.Text = user.Status.ToString();
        }

        protected void btnUpdate_Clicked(object sender, EventArgs e)
        {
            String currentId = Session["UserID"].ToString();
            if (!txtUserId.Text.Equals("null"))
            {
                if (txtUserId.Text == currentId)
                {
                    ErrorMessage("Anda tidak bisa mengubah data diri anda sendiri");
                }
                else
                {
                    int id = Int32.Parse(txtUserId.Text);
                    String roleId = txtUserRole.Text;
                    String userStatus = txtStatus.SelectedValue.ToString();

                    TokopediaMain.Repository.UserRepository.UpdateHakAkses(id, roleId, userStatus);
                    Response.Redirect("./View User.aspx");
                }
            }
            else
            {
                ErrorMessage("Silahkan pilih data yang ingin diubah!");
            }

        }

        protected void Delete_Clicked(object sender, EventArgs e)
        {
            String Id = Session["UserID"].ToString();
            int currentID = Int32.Parse(txtUserId.Text); ;

            if (!txtUserId.Text.Equals("null"))
            {
                if (txtUserId.Text == Id)
                {
                    ErrorMessage("Anda tidak bisa menghapus akun anda sendiri");
                }
                else
                {
                    if(Repository.HeaderTransactionRepository.getDataByID(currentID) == null)
                    {
                        TokopediaMain.Repository.UserRepository.Delete(currentID);
                        Response.Redirect("./View User.aspx");
                    }
                    else
                    {
                        ErrorMessage("User ini sedang melakukan transaksi");
                    }

                }
            }
            else
            {
                ErrorMessage("Silahkan pilih data yang ingin didelete!");
            }
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