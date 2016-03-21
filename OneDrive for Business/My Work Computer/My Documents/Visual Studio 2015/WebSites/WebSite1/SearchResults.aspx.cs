using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class SearchResults : System.Web.UI.Page
{
    public static bool notInitialLoad = false;

    protected void Page_Load(object sender, EventArgs e)
    {
        noCoursesFoundBox.Visible = false;

        string searchCondition = SiteMaster.wildCardCourse;

        if (searchCondition != null)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SNDB;User ID=SA;Password=SeniorSem123";

            //sqlConn = new SqlConnection(connetionString);
            //sqlConn.Open();




            string query = "SELECT * FROM COURSES WHERE CourseTitle LIKE " + "'%" + searchCondition + "%';";
            List<string> potentialCourses = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                conn.Open();
                command.Connection = conn;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = query;
                //conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    potentialCourses.Add(reader[1].ToString() + " - " + reader[2].ToString());
                }


            }
            potentialCourses.Sort();

            if (!potentialCourses.Any())
            {
                ListBox1.Visible = false;
                noCoursesFoundBox.Visible = true;
                noCoursesFoundBox.Text = "We're sorry, no courses with that name could be found.";
            }
            else
            {
                ListBox1.Visible = true;
                ListBox1.DataSource = potentialCourses;
                ListBox1.DataBind();
            }


        }
        notInitialLoad = true;

    }

    public void listBox1_MouseDoubleClick(object sender, EventArgs e)
    {
        Console.WriteLine("test");
    }
}