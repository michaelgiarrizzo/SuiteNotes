﻿<%@ Page Title="Course" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="Course" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Course CSC 490 Spring 2016</h1>
        <h2> Professor: Chays</h2>
        
    </div>
    
    <div class="row">
         <div class="col-md-8">
            <h2>Week 1</h2>
            <asp:FileUpload ID="FileUpload1" runat="server" EnableViewState="false"/>

<asp:Button ID="UploadButton1" runat="server" Text="Upload" OnClick="UploadFile" AutoPostBack ="False"/>

<hr />
<p> <asp:Label ID="Label1" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

    <Columns>

        <asp:BoundField DataField="Text" HeaderText="File Name" />

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />

            </ItemTemplate>

        </asp:TemplateField>

    </Columns>

</asp:GridView>
        </div>
    </div>

    <div class="row">
         <div class="col-md-8">
            <h2>Week 2</h2>
           <asp:FileUpload ID="FileUpload2" runat="server" />

<asp:Button ID="UploadButton2" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label2" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

    <Columns>

        <asp:BoundField DataField="Text" HeaderText="File Name" />

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile2"></asp:LinkButton>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile2" />

            </ItemTemplate>

        </asp:TemplateField>

    </Columns>

</asp:GridView>
        </div>
         <div class="col-md-8">
            <h2>Week 3</h2>
          <asp:FileUpload ID="FileUpload3" runat="server" />

<asp:Button ID="UploadButton3" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label3" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

    <Columns>

        <asp:BoundField DataField="Text" HeaderText="File Name" />

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />

            </ItemTemplate>

        </asp:TemplateField>

    </Columns>

</asp:GridView>
        </div>
         <div class="col-md-8">
            <h2>Week 4</h2>
          <asp:FileUpload ID="FileUpload4" runat="server" />

<asp:Button ID="Button4" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label4" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

    <Columns>

        <asp:BoundField DataField="Text" HeaderText="File Name" />

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />

            </ItemTemplate>

        </asp:TemplateField>

    </Columns>

</asp:GridView>
        </div>
         <div class="col-md-8">
            <h2>Week 5</h2>
        <asp:FileUpload ID="FileUpload5" runat="server" EnableViewState="false" />

<asp:Button ID="Button5" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label5" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

    <Columns>

        <asp:BoundField DataField="Text" HeaderText="File Name" />

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />

            </ItemTemplate>

        </asp:TemplateField>

    </Columns>

</asp:GridView>
        </div>
         <div class="col-md-8">
            <h2>Week 6</h2>
            <asp:FileUpload ID="FileUpload6" runat="server" />

<asp:Button ID="Button6" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label6" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

    <Columns>

        <asp:BoundField DataField="Text" HeaderText="File Name" />

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />

            </ItemTemplate>

        </asp:TemplateField>

    </Columns>

</asp:GridView>
        </div>

         <div class="col-md-8">
            <h2>Week 7</h2>
          <asp:FileUpload ID="FileUpload7" runat="server" />

<asp:Button ID="Button7" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label7" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

    <Columns>

        <asp:BoundField DataField="Text" HeaderText="File Name" />

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField>

            <ItemTemplate>

                <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />

            </ItemTemplate>

        </asp:TemplateField>

    </Columns>

</asp:GridView>
        </div>
       
    </div>
</asp:Content>