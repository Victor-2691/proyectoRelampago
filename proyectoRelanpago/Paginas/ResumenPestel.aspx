<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResumenPestel.aspx.cs" Inherits="proyectoRelanpago.Paginas.ResumenPestel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Estilos/ResumenPestel.css" rel="stylesheet" />

    <div class="cont">

        <div class="divTitulo">
            <p>Resumen PESTEL</p>
        </div>

        <div class="contResumen">
            <div class="caja">
                <p class="tituloFactor">Factores políticos</p>
                <ul>
                    <li class="factores">Gobierno</li>
                    <li class="factores">Políticas gubernamental es del sector empresarial</li>
                </ul>
            </div>
            <div class="caja">
                 <p class="tituloFactor">Factores económicos</p>
            </div>
            <div class="caja">
                <p class="tituloFactor">Factores sociales</p>
            </div>
            <div class="caja">
                <p class="tituloFactor">Factores tecnológicos</p>
            </div>
            <div class="caja">
                <p class="tituloFactor">Factores ecológicos</p>
            </div>
            <div class="caja">
                <p class="tituloFactor">Factores legales</p>
            </div>
        </div>

        <div class="divBoton">
            <asp:Button class="botonSiguiente" ID="btnRedirigir" runat="server" Text="PÁGINA PRINCIPAL" />
        </div>
    </div>

</asp:Content>
