<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AzurreWebAppDB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="Button1" runat="server" Text="Show Data" OnClick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" >
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="student" HeaderText="student" SortExpression="student" />
            <asp:BoundField DataField="program" HeaderText="program" SortExpression="program" />
        </Columns>
    </asp:GridView>

<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:emergingDbConnectionString %>" SelectCommand="SELECT * FROM [customer]"></asp:SqlDataSource>

    <h4>CRUD data by ID</h4>
    <asp:TextBox ID="TextBox1" runat="server" Text="Id" hint="ID"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" Text="student" hint="student"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server" Text="program" hint="program"></asp:TextBox>
<asp:Button ID="Button2" runat="server" Text="update" OnClick="Button1_Update" />
    <asp:Button ID="Button3" runat="server" Text="add" OnClick="Button1_add" />
    <asp:Button ID="Button4" runat="server" Text="delete" OnClick="Button1_delete" />


</asp:Content>
