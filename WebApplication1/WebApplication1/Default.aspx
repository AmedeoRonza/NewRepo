<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
            <div id="form1" runat="server">
                <asp:Button id="Button1" runat="server" Text="Leggi dati da Web.config" OnClick="Button1_Click"/>
            </div>       
    </main>

</asp:Content>
