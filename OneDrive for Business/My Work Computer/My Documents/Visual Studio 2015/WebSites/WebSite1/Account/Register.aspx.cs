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
    static string username = null;
    static string password = null;
    static string confpassword = null;

    public void connection()
    {

        constrReg = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        conReg = new SqlConnection(constrReg);
        conReg.Open();

    }

    protected void CreateUser_Click(object sender, EventArgs e)
    {
        username = UserName.Text;
        password = Password.Text;
        confpassword = ConfirmPassword.Text;
        // int uid = 101;
        // var manager = new UserManager();
        // var user = new ApplicationUser() { UserName = UserName.Text };

        /*   IdentityResult result = manager.Create(user, Password.Text); */
        if (username != null && username != "" && password != null && password != "" && password == confpassword)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SNDB;User ID=SA;Password=SeniorSem123";
            //insert userID, userName, Password, ProfileID (set to null for now because we might have library later), isAdmin (set to false for now?)
            string insert = "INSERT INTO Users VALUES ('" + username + "', '" + password + "'," + 0 + ");";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insert);
                conn.Open();
                command.Connection = conn;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = insert;
                command.ExecuteNonQuery();
                Console.WriteLine("test User data");


            }
        }
        //if (result.Succeeded)
        //{
        //    IdentityHelper.SignIn(manager, user, isPersistent: false);
        //    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
        //}
        //else
        //{
        //    ErrorMessage.Text = result.Errors.FirstOrDefault();
        //}
    }
}