using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;



public partial class _Default : Page
{
    protected void UploadFile(object sender, EventArgs e)

    {

        string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

       FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Uploads/1/") + fileName);

        Response.Redirect(Request.Url.AbsoluteUri);

    }
    protected void Page_Load(object sender, EventArgs e)

    {


        if (!IsPostBack)

        {

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