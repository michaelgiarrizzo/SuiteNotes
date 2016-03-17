using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*This code first verifies that a file has been uploaded. 
If no file was selected, you receive the "Please select a file to upload" message. 
If a valid file is uploaded, its file name is extracted by using the System.IO namespace, and its destination is assembled in a SaveAs path. 
After the final destination is known, the file is saved by using the File1.PostedFile.SaveAs method. 
Any exception is trapped, and the exception message is displayed on the screen.
Website for reference: https://support.microsoft.com/en-us/kb/323246
*/


namespace uploadFileToWebServer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private void Submit1_ServerClick(object sender, System.EventArgs e)
        {

            if ((File1.PostedFile != null) && (File1.PostedFile.ContentLength > 0))
            {
                string fn = System.IO.Path.GetFileName(File1.PostedFile.FileName);
                string SaveLocation = Server.MapPath("Data") + "\\" + fn;
                try
                {
                    File1.PostedFile.SaveAs(SaveLocation);
                    Response.Write("The file has been uploaded.");
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                    //Note: Exception.Message returns a detailed message that describes the current exception. 
                    //For security reasons, we do not recommend that you return Exception.Message to end users in 
                    //production environments. It would be better to put a generic error message. 
                }
            }
            else
            {
                Response.Write("Please select a file to upload.");
            }

        }
    }
}