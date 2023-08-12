<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your contact page </h3>
    <h3>&nbsp;</h3>
    <h3>&nbsp;</h3>
    <h3>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h3>
    <h3>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h3>
    <h3>.<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="179px" />
    </h3>
        <address>
            One Microsoft Way<br />
            Redmond, WA 98052-6399<br />
            <abbr title="Phone">P:</abbr>
            425.555.0100
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
        </address>
    </main>
</asp:Content>
