<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AzurreWebAppDB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" >
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="student" HeaderText="student" SortExpression="student" />
            <asp:BoundField DataField="program" HeaderText="program" SortExpression="program" />
        </Columns>
    </asp:GridView>

<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:emergingDbConnectionString %>" SelectCommand="SELECT * FROM [customer]"></asp:SqlDataSource>
<asp:EntityDataSource ID="EntityDataSource1" runat="server">

</asp:EntityDataSource>
</asp:Content>
