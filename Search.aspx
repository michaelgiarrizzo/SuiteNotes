<%@ Page Language="VB" %>

<!DOCTYPE html>

<script runat="server">

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)


    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    <div id ="search_txt_search">
     <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="327px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Height="28px" Text="Search " Width="88px" />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br />
    </div>
       
    </form>
</body>
</html>
