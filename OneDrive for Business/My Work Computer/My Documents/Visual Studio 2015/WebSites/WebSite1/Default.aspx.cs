using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public partial class _Default : Page
{
    public string query, constr;
    public SqlCommand com;
    public SqlConnection con;

    public void connection()
    {

        constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        con = new SqlConnection(constr);
        con.Open();

    }
    protected void UploadFile(object sender, EventArgs e)

    {
        Label2.Visible = true;
        string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

        string ext = Path.GetExtension(fileName);

        string type = String.Empty;

        if (!FileUpload1.HasFile)
        {

            Label2.Text = "Please Select File";//if file uploader has no file selected

        }
        else

        if (FileUpload1.HasFile)

        {

            try

            {


                switch (ext)                                         // this switch code validate the files which allow to upload only PDF  file 

                {

                    case ".pdf":

                        type = "application/pdf";

                        break;



                }


                if (type != String.Empty)

                {

                    connection();

                    Stream fs = FileUpload1.PostedFile.InputStream;

                    BinaryReader br = new BinaryReader(fs);                                 //reads the   binary files

                    Byte[] bytes = br.ReadBytes((Int32)fs.Length);                           //counting the file length into bytes

                    query = "insert into Properties (Name,type,data)" + " values (@Name, @type, @Data)";   //insert query

                    com = new SqlCommand(query, con);

                    com.Parameters.Add("@Name", SqlDbType.VarChar).Value = fileName;

                    com.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

                    com.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;

                    com.ExecuteNonQuery();

                    Label2.ForeColor = System.Drawing.Color.Green;

                    Label2.Text = "File Uploaded Successfully";

                }

                else

                {

                    Label2.ForeColor = System.Drawing.Color.Red;

                    Label2.Text = "Select Only PDF Files  ";                              // if file is other than speified extension 

                }

            }

            catch (Exception ex)

            {

                Label2.Text = "Error: " + ex.Message.ToString();

            }


            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Uploads/1/") + fileName);

            Response.Redirect(Request.Url.AbsoluteUri);

        }
    }

        protected void Button2_Click(object sender, EventArgs e)

    {

        connection();

        query = "Select *from PDFFiles";

        SqlDataAdapter da = new SqlDataAdapter(query, con);

        DataSet ds = new DataSet();

        da.Fill(ds);

        GridView1.DataSource = ds;

        GridView1.DataBind();

        con.Close();


    }
    protected void Page_Load(object sender, EventArgs e)

    {
        

        if (!IsPostBack)

        {
            //getting the filepath of the uploaded file
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Uploads/1/"));

            List<ListItem> files = new List<ListItem>();
            
            foreach (string filePath in filePaths)

            {

                files.Add(new ListItem(Path.GetFileName(filePath), filePath));

            }

            GridView1.DataSource = files;
            
            GridView1.DataBind();

            string[] filePaths2 = Directory.GetFiles(Server.MapPath("~/Uploads/2/"));

            List<ListItem> files2 = new List<ListItem>();

            foreach (string filePath in filePaths2)

            {

                files2.Add(new ListItem(Path.GetFileName(filePath), filePath));

            }

            gv2.DataSource = files2;
         
            gv2.DataBind();

            string[] filePaths3 = Directory.GetFiles(Server.MapPath("~/Uploads/3/"));

            List<ListItem> files3 = new List<ListItem>();

            foreach (string filePath in filePaths3)

            {

                files2.Add(new ListItem(Path.GetFileName(filePath), filePath));

            }

            GridView3.DataSource = files3;

            GridView3.DataBind();
        }

}

    protected void DownloadFile(object sender, EventArgs e)

    {

        string filePath = (sender as LinkButton).CommandArgument;

        Response.ContentType = ContentType;

        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));

        Response.WriteFile(filePath);

        Response.End();

    }

    protected void DeleteFile(object sender, EventArgs e)

    {

        string filePath = (sender as LinkButton).CommandArgument;

        File.Delete(filePath);

        Response.Redirect(Request.Url.AbsoluteUri);

    }

    protected void UploadFile2(object sender, EventArgs e)

    {

        string fileName = Path.GetFileName(FileUpload2.PostedFile.FileName);

        FileUpload2.PostedFile.SaveAs(Server.MapPath("~/Uploads/2/") + fileName);

        Response.Redirect(Request.Url.AbsoluteUri);

    }

    protected void DownloadFile2(object sender, EventArgs e)

    {

        string filePath2 = (sender as LinkButton).CommandArgument;

        Response.ContentType = ContentType;

        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath2));

        Response.WriteFile(filePath2);

        Response.End();

    }

    protected void DeleteFile2(object sender, EventArgs e)

    {

        string filePath2 = (sender as LinkButton).CommandArgument;

        File.Delete(filePath2);

        Response.Redirect(Request.Url.AbsoluteUri);

    }

    protected void UploadFile3(object sender, EventArgs e)

    {

        string fileName3 = Path.GetFileName(FileUpload3.PostedFile.FileName);

        FileUpload3.PostedFile.SaveAs(Server.MapPath("~/Uploads/3/") + fileName3);

        Response.Redirect(Request.Url.AbsoluteUri);

    }

    protected void DownloadFile3(object sender, EventArgs e)

    {

        string filePath3 = (sender as LinkButton).CommandArgument;

        Response.ContentType = ContentType;

        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath3));

        Response.WriteFile(filePath3);

        Response.End();

    }

    protected void DeleteFile3(object sender, EventArgs e)

    {

        string filePath3 = (sender as LinkButton).CommandArgument;

        File.Delete(filePath3);

        Response.Redirect(Request.Url.AbsoluteUri);

    }
}