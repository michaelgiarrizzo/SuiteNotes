using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using WebSite1;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Account_Register : Page
{
    public string queryReg, constrReg;
    public SqlCommand comReg;
    public SqlConnection conReg;

    public void connection()
    {

        constrReg = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        conReg = new SqlConnection(constrReg);
        conReg.Open();

    }

    protected void CreateUser_Click(object sender, EventArgs e)
    {
        var manager = new UserManager();
        var user = new ApplicationUser() { UserName = UserName.Text };
        IdentityResult result = manager.Create(user, Password.Text);

        if (user != null && UserName.Text != "" && result !=null && Password.Text != "")
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SNDB;User ID=SA;Password=SeniorSem123";
            //insert userID, userName, Password, ProfileID (set to null for now because we might have library later), isAdmin (set to false for now?)
            string insert = "INSERT INTO User VALUES (1, '" + UserName.Text +"', '"+ Password.Text +"', '"+ null +"', '" + false +"');" ;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insert);
                conn.Open();
                command.Connection = conn;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = insert;
                command.ExecuteNonQuery();
                Console.WriteLine("test");


            }
        }


        if (result.Succeeded)
        {
            IdentityHelper.SignIn(manager, user, isPersistent: false);
            IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
        }
        else
        {
            ErrorMessage.Text = result.Errors.FirstOrDefault();
        }
    }
}