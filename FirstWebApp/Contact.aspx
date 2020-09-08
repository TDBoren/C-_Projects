﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FirstWebApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <%: Title %>.<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h2>
    <h3>Your contact page.</h3>
    <address>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>