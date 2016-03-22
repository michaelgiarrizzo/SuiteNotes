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



public partial class Course : System.Web.UI.Page
{
    public string query, constr;
    public SqlCommand com;
    public SqlConnection con;
    public static string fullCourseName = null;
    public static string courseCode = null;

    public void connection()
    {

        constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        con = new SqlConnection(constr);
        con.Open();

    }
    protected void UploadFile(object sender, EventArgs e)

    {
        Button selectedButton = sender as Button;
        string buttonString = selectedButton.ClientID.ToString();
        string fileName = null;
        string ext = null;
        string week = "Week";
        string desiredExt = ".txt";
        string savePath = null;


        switch (buttonString)
        {
            case "MainContent_UploadButton1":
                if (FileUpload1.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    week = week + "1";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label1.ForeColor = System.Drawing.Color.Red;
                        Label1.Visible = true;
                        Label1.Text = "Please select only text files";
                        break;
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload1.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Please Select File";
                }

                break;
            case "MainContent_UploadButton2":
                if (FileUpload2.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload2.PostedFile.FileName);
                    week = week + "2";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label2.ForeColor = System.Drawing.Color.Red;
                        Label2.Visible = true;
                        Label2.Text = "Please select only text files";
                        break;
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload2.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label2.Visible = true;
                    Label2.Text = "Please Select File";
                }


                break;
            case "MainContent_UploadButton3":
                if (FileUpload3.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload3.PostedFile.FileName);
                    week = week + "3";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label3.ForeColor = System.Drawing.Color.Red;
                        Label3.Visible = true;
                        Label3.Text = "Please select only text files";
                        break;
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload3.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label3.Visible = true;
                    Label3.Text = "Please Select File";
                }

                break;
            case "MainContent_UploadButton4":
                if (FileUpload4.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload4.PostedFile.FileName);
                    week = week + "4";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label4.ForeColor = System.Drawing.Color.Red;
                        Label4.Visible = true;
                        Label4.Text = "Please select only text files";
                        break;
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload4.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label4.Visible = true;
                    Label4.Text = "Please Select File";
                }

                break;
            case "MainContent_UploadButton5":
                if (FileUpload5.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload5.PostedFile.FileName);
                    week = week + "5";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label5.ForeColor = System.Drawing.Color.Red;
                        Label5.Visible = true;
                        Label5.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload5.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label5.Visible = true;
                    Label5.Text = "Please Select File";
                }

                break;
            case "MainContent_UploadButton6":
                if (FileUpload6.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload6.PostedFile.FileName);
                    week = week + "6";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label6.ForeColor = System.Drawing.Color.Red;
                        Label6.Visible = true;
                        Label6.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload6.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label6.Visible = true;
                    Label6.Text = "Please Select File";
                }
                break;
            case "MainContent_UploadButton7":
                if (FileUpload7.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload7.PostedFile.FileName);
                    week = week + "7";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label7.ForeColor = System.Drawing.Color.Red;
                        Label7.Visible = true;
                        Label7.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload7.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label7.Visible = true;
                    Label7.Text = "Please Select File";
                }
                break;

        }

        if (fileName != null && fileName != "" && Path.GetExtension(fileName) == desiredExt)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SNDB;User ID=SA;Password=SeniorSem123";
            string insert = "INSERT INTO Notes VALUES (1, (SELECT CourseID FROM Courses WHERE CourseName = '" + courseCode + "'), '" + fileName.Substring(0, fileName.Length - 4) + "', 'default desc', -1, '" + savePath + "', '" + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.0000000") + "', '" + Convert.ToInt32(week.Substring(week.Length - 1)) + "');";


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




        //Response.Redirect(Request.Url.AbsoluteUri);


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
            fullCourseName = SearchResults.selectedCourse;
            if (fullCourseName != null)
            {
                courseCode = fullCourseName.Substring(0, 6);


                string courseDirPath = Server.MapPath("~/Uploads/" + courseCode + "/");

                if (!Directory.Exists(courseDirPath))
                {
                    Directory.CreateDirectory(courseDirPath);
                    Directory.CreateDirectory(courseDirPath + "/Week1/");
                    Directory.CreateDirectory(courseDirPath + "/Week2/");
                    Directory.CreateDirectory(courseDirPath + "/Week3/");
                    Directory.CreateDirectory(courseDirPath + "/Week4/");
                    Directory.CreateDirectory(courseDirPath + "/Week5/");
                    Directory.CreateDirectory(courseDirPath + "/Week6/");
                    Directory.CreateDirectory(courseDirPath + "/Week7/");
                }


                List<ListItem> week1List = getWeekFiles(courseDirPath + "/Week1/");
                GridView1.DataSource = week1List;
                GridView1.DataBind();
                List<ListItem> week2List = getWeekFiles(courseDirPath + "/Week2/");
                GridView2.DataSource = week2List;
                GridView2.DataBind();
                List<ListItem> week3List = getWeekFiles(courseDirPath + "/Week3/");
                GridView3.DataSource = week3List;
                GridView3.DataBind();
                List<ListItem> week4List = getWeekFiles(courseDirPath + "/Week4/");
                GridView4.DataSource = week4List;
                GridView4.DataBind();
                List<ListItem> week5List = getWeekFiles(courseDirPath + "/Week5/");
                GridView5.DataSource = week5List;
                GridView5.DataBind();
                List<ListItem> week6List = getWeekFiles(courseDirPath + "/Week6/");
                GridView6.DataSource = week6List;
                GridView6.DataBind();
                List<ListItem> week7List = getWeekFiles(courseDirPath + "/Week7/");
                GridView7.DataSource = week7List;
                GridView7.DataBind();
                //List<ListItem> week2List = getWeekFiles
            }




        }

    }

    public static List<ListItem> getWeekFiles(string _dirPath)
    {
        List<ListItem> curWeekFileListItems = new List<ListItem>();
        List<string> curWeekFileStrings = Directory.GetFiles(_dirPath).ToList();
        foreach (var filePath in curWeekFileStrings)
        {
            curWeekFileListItems.Add(new ListItem(Path.GetFileName(filePath), filePath));
        }
        return curWeekFileListItems;

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