<%@ Page Language="C#" StyleSheetTheme="" %>

<!DOCTYPE html>
<script runat="server">

    // protected void btn_searcher(object sender, EventArgs e)
    //{
    //   btn_search.Text = "complete.";
    // Console.WriteLine("Hello World!");

    //}

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.Text = "Searching...";
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox1.Text = "...";
    }
</script>




<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Home.css" rel="stylesheet" type="text/css" />
    <title>SuiteNotes.com</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id ="Logo" style="font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: larger; font-weight: bold; font-style: italic; font-variant: normal; color: #66FF33; width: 1028px; height: 44px; margin-left: 120px; background-color: #FFFFFF;">
    
        <br />
        <br />
       
    </div>
    <div style="height: 800px; background-color: #FFFFFF; width: 1028px; margin-left: 120px;">
            <ul>
                <li style="border: thick double #C0C0C0"> <a href ="index.aspx">Home</a></li>
                <li style="border: thick double #C0C0C0"> <a href ="FirstWebPage.aspx">Search</a></li>
                <li style="border: thick double #C0C0C0"> <a href ="FirstWebPage.aspx">Help</a></li>
                <li style="border: thick double #C0C0C0"> <a href ="FirstWebPage.aspx">About Us</a></li>
            </ul>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="540px" OnTextChanged="TextBox1_TextChanged" style="color: #FFFFFF; background-color: #00BFFF"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" Width="114px" style="color: #FFFFFF; background-color: #00BFFF" />
        <br />
        <h1>Search for your class notes here!</h1>
            <p><ul "Search Notes</ul>
             
                </p>
    </div>
    </form>
    </body>
</html>
