<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Return.aspx.cs" Inherits="BookShelfPresentationLayer.Return" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row main">
            <div class="main-login main-center">
                <div class="form-group">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </div>
                <div class="form-group">
                    Enter ISBN to return a book
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtISBN" placeholder="Enter ISBN" CssClass="form-control" required runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnReturn" runat="server" CssClass="btn btn-primary " Text="Return" OnClick="btnReturn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
