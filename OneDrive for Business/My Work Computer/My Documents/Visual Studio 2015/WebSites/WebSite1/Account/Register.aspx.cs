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
        connection();

        //insert query
        queryReg = "insert into User (UserName,Password,ProfileID,IsAdmin)" + " values (@Username, @Password, @ProfileID, @IsAdmin)";   

        //comReg = new SqlCommand(queryReg, conReg);

        //comReg.Parameters.Add("@Username", SqlDbType.VarChar).Value = UserName;

        //comReg.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password.Text;

        //comReg.Parameters.Add("@ProfileID", SqlDbType.VarChar).Value = null;

        //comReg.Parameters.Add("@IsAdmin", SqlDbType.TinyInt).Value = 0;

        //comReg.ExecuteNonQuery();
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