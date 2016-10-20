<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MySite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Create Account" OnClick="Button_click" Style="background-color: gray; border-color: black; height: 30px; width: 100px; margin: 5px" />
    <div>
        <asp:TextBox ID="name" runat="server" placeholder="Name" type="text" Style="width: 240px; margin-left: 5px"></asp:TextBox>
    </div>
    <div>
        <asp:TextBox ID="website" runat="server"  placeholder="Website"  type="text" Style="width: 240px; margin-left: 5px"></asp:TextBox>
    </div>
    <div>
        <asp:TextBox ID="entityNumber" runat="server"  placeholder="Entity number" type="text" Style="width: 240px; margin-left: 5px"></asp:TextBox>
    </div>
</asp:Content>
