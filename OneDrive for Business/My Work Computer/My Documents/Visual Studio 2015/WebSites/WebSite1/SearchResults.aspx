<%@ Page Title="SearchResults" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="SearchResults.aspx.cs" Inherits="SearchResults" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div style= "width: 400px; margin-left: auto; margin-right:auto;" >
    <asp:ListBox ID="ListBox1" Font-Italic="true" AccessKey="p" Width="400" Height="300"  runat="server"></asp:ListBox>     
    <asp:TextBox ID="noCoursesFoundBox" Font-Bold="true" runat="server" ForeColor="Black" BackColor="Wheat" Font-Italic="true" Width="375" ReadOnly="true" Visible="false"></asp:TextBox>   
    <asp:button ID="toCourseButton" runat="server" Text="Go" onclick ="toCourseButton_Click"/>  
    </div>
    
</asp:Content>