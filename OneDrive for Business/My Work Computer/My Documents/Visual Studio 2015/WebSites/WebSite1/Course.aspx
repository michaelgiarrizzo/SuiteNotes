<%@ Page Title="Course" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="Course" %>
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
       <div class="col-md-8">
            <h2>Week 8</h2>
          <asp:FileUpload ID="FileUpload8" runat="server" />

<asp:Button ID="Button8" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label8" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

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
            <h2>Week 9</h2>
          <asp:FileUpload ID="FileUpload9" runat="server" />

<asp:Button ID="Button9" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label9" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

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
            <h2>Week 10</h2>
          <asp:FileUpload ID="FileUpload10" runat="server" />

<asp:Button ID="Button10" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label10" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView10" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

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
            <h2>Week 11</h2>
          <asp:FileUpload ID="FileUpload11" runat="server" />

<asp:Button ID="Button11" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label11" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView11" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

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
            <h2>Week 12</h2>
          <asp:FileUpload ID="FileUpload12" runat="server" />

<asp:Button ID="Button12" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label12" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView12" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

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
            <h2>Week 13</h2>
          <asp:FileUpload ID="FileUpload13" runat="server" />

<asp:Button ID="Button13" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label13" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView13" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

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
            <h2>Week 14</h2>
          <asp:FileUpload ID="FileUpload14" runat="server" />

<asp:Button ID="Button14" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label14" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView14" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

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
            <h2>Week 15</h2>
          <asp:FileUpload ID="FileUpload15" runat="server" />

<asp:Button ID="Button15" runat="server" Text="Upload" OnClick="UploadFile" />

<hr />
<p> <asp:Label ID="Label15" runat="server" Text="label"></asp:Label>  </p>
<asp:GridView ID="GridView15" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded">

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
