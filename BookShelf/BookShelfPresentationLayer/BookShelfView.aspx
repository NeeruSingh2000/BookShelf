<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookShelfView.aspx.cs" Inherits="BookShelfPresentationLayer.BookShelfView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row main">
            <div class="main-login main-center">
                <div class="form-group">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </div><div class="form-group">
                    Below is the list of all books on bookshelf 
                </div>
                <div class="form-group ">
                    <asp:GridView ID="grdBooks" CssClass="table table-striped table-bordered table-condensed" runat="server"></asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
