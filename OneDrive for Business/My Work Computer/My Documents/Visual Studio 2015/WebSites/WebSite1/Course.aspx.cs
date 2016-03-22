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
            case "MainContent_UploadButton8":
                if (FileUpload8.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload8.PostedFile.FileName);
                    week = week + "8";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label8.ForeColor = System.Drawing.Color.Red;
                        Label8.Visible = true;
                        Label8.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload8.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label8.Visible = true;
                    Label8.Text = "Please Select File";
                }
                break;
            case "MainContent_UploadButton9":
                if (FileUpload9.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload9.PostedFile.FileName);
                    week = week + "9";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label9.ForeColor = System.Drawing.Color.Red;
                        Label9.Visible = true;
                        Label9.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload9.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label9.Visible = true;
                    Label9.Text = "Please Select File";
                }
                break;
            case "MainContent_UploadButton10":
                if (FileUpload7.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload10.PostedFile.FileName);
                    week = week + "10";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label10.ForeColor = System.Drawing.Color.Red;
                        Label10.Visible = true;
                        Label10.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload10.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label10.Visible = true;
                    Label10.Text = "Please Select File";
                }
                break;
            case "MainContent_UploadButton11":
                if (FileUpload11.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload11.PostedFile.FileName);
                    week = week + "11";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label11.ForeColor = System.Drawing.Color.Red;
                        Label11.Visible = true;
                        Label11.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload11.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label11.Visible = true;
                    Label11.Text = "Please Select File";
                }
                break;
            case "MainContent_UploadButton12":
                if (FileUpload12.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload12.PostedFile.FileName);
                    week = week + "12";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label12.ForeColor = System.Drawing.Color.Red;
                        Label12.Visible = true;
                        Label12.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload12.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label12.Visible = true;
                    Label12.Text = "Please Select File";
                }
                break;
            case "MainContent_UploadButton13":
                if (FileUpload13.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload13.PostedFile.FileName);
                    week = week + "13";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label13.ForeColor = System.Drawing.Color.Red;
                        Label13.Visible = true;
                        Label13.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload13.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label13.Visible = true;
                    Label13.Text = "Please Select File";
                }
                break;
            case "MainContent_UploadButton14":
                if (FileUpload14.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload14.PostedFile.FileName);
                    week = week + "14";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label14.ForeColor = System.Drawing.Color.Red;
                        Label14.Visible = true;
                        Label14.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload14.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label14.Visible = true;
                    Label14.Text = "Please Select File";
                }
                break;
            case "MainContent_UploadButton15":
                if (FileUpload15.PostedFile != null)
                {
                    fileName = Path.GetFileName(FileUpload15.PostedFile.FileName);
                    week = week + "15";
                    ext = Path.GetExtension(fileName);
                    if (Path.GetExtension(fileName) != desiredExt)
                    {
                        Label15.ForeColor = System.Drawing.Color.Red;
                        Label15.Visible = true;
                        Label15.Text = "Please select only text files";
                    }
                    savePath = Path.Combine(Server.MapPath("~/Uploads/"), courseCode, week, fileName);
                    FileUpload15.PostedFile.SaveAs(savePath);
                }
                else
                {
                    Label15.Visible = true;
                    Label15.Text = "Please Select File";
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
                List<ListItem> week8List = getWeekFiles(courseDirPath + "/Week8/");
                GridView8.DataSource = week8List;
                GridView8.DataBind();
                List<ListItem> week9List = getWeekFiles(courseDirPath + "/Week9/");
                GridView9.DataSource = week9List;
                GridView9.DataBind();
                List<ListItem> week10List = getWeekFiles(courseDirPath + "/Week10/");
                GridView10.DataSource = week10List;
                GridView10.DataBind();
                List<ListItem> week11List = getWeekFiles(courseDirPath + "/Week11/");
                GridView11.DataSource = week11List;
                GridView11.DataBind();
                List<ListItem> week12List = getWeekFiles(courseDirPath + "/Week12/");
                GridView12.DataSource = week12List;
                GridView12.DataBind();
                List<ListItem> week13List = getWeekFiles(courseDirPath + "/Week13/");
                GridView13.DataSource = week13List;
                GridView13.DataBind();
                List<ListItem> week14List = getWeekFiles(courseDirPath + "/Week14/");
                GridView14.DataSource = week14List;
                GridView14.DataBind();
                List<ListItem> week15List = getWeekFiles(courseDirPath + "/Week15/");
                GridView15.DataSource = week15List;
                GridView15.DataBind();
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