﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Factores.aspx.cs" Inherits="proyectoRelanpago.Paginas.Factores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Estilos/Factores.css" rel="stylesheet" />

    <div class="divParrafoEx">
        <p class="parrEx">Digite las variables del entorno interno o externo, que afectan, o podrían afectar, de manera positiva o negativa para cumplir los requerimientos ideales</p>
    </div>

    <div class="cont">
        <div class="divTitulo">
            <p>Lista de factores</p>
        </div>


        <asp:GridView ID="grdFactores" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" ForeColor="Black" GridLines="Horizontal" class="tablaFactores">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>

        <div class="divBoton">
            <asp:Button class="botonSiguiente" ID="btnContinuar" runat="server" Text="CONFIRMAR FACTORES" />
        </div>
    </div>

</asp:Content>