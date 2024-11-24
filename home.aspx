<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Projeto_Biblioteca.Home" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Adicionar Novo Livro</h2>

    <div>
        <label for="txtTitulo">Título:</label>
        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox><br /><br />

        <label for="txtAutor">Autor:</label>
        <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox><br /><br />

        <label for="txtAno">Ano:</label>
        <asp:TextBox ID="txtAno" runat="server"></asp:TextBox><br /><br />

        <label for="txtISBN">ISBN:</label>
        <asp:TextBox ID="txtISBN" runat="server"></asp:TextBox><br /><br />

        <label for="txtNumeroDePaginas">Número de Páginas:</label>
        <asp:TextBox ID="txtNumeroDePaginas" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar Livro" OnClick="btnAdicionar_Click" /><br /><br />
    </div>
</asp:Content>
