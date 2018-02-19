<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Loan.aspx.cs" Inherits="BookShelfPresentationLayer.Loan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row main">
            <div class="main-login main-center">
                <div class="form-group">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </div>
                <div class="form-group">
                    Enter ISBN to loan a book
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtISBN" CssClass="form-control" placeholder="Enter ISBN" required runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnLoan" CssClass="btn btn-primary " runat="server" Text="Loan" OnClick="btnLoan_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
