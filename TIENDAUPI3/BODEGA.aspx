<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="BODEGA.aspx.cs" Inherits="TIENDAUPI3.BODEGA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h1>CATALOGO DE BODEGAS </h1>
    </div>
    <div class="text-center">
        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    </div>
    <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Codigo:</label>
        <asp:TextBox ID="tcodigo" class="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="exampleInputPassword1" class="form-label">Descripcion</label>
        <asp:TextBox ID="tnombre" class="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="text-center">
        <asp:Button ID="bagregar" runat="server" Text="Agregar" OnClick="bagregar_Click" />
        <asp:Button ID="bborrar" runat="server" Text="Borrar" OnClick="bborrar_Click" />
        <asp:Button ID="bmodificar" runat="server" Text="Modificar" OnClick="bmodificar_Click" />
        <asp:Button ID="bconsultar" runat="server" Text="Consultar" />
    </div>
</asp:Content>
