<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResumenHistorico.aspx.cs" Inherits="proyectoRelanpago.Paginas.ResumenHistorico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Estilos/ResumenPestel.css" rel="stylesheet" />

    <div class="cont">

        <div class="divTitulo">
            <p>Resumen PESTEL</p>
        </div>

        <div class="contResumen" id="divcaja" runat="server">
       <div class="caja" >
                <p class="tituloFactor">Factores políticos</p>
                <ul  id="divpolitico" runat="server">
    
                </ul>
            </div>

            <div class="caja">
                 <p class="tituloFactor">Factores económicos</p>
                <ul id="diveconomico" runat="server">

                </ul>
            </div>

            <div class="caja">
                <p class="tituloFactor">Factores sociales</p>
            <ul id="divsociales" runat="server">
                </ul>
            </div>


            <div class="caja">
                <p class="tituloFactor">Factores tecnológicos</p>
                 <ul id="divtecnologicos" runat="server">
                </ul>
            </div>

            <div class="caja">
                <p class="tituloFactor">Factores ecológicos</p>
                <ul id="divecologicos" runat="server">
                </ul>
                </div>

            <div class="caja">
                <p class="tituloFactor">Factores legales</p>
                  <ul id="divlegales" runat="server">
                </ul>
            </div>
       
            </div>

        <div class="divBoton">
            <asp:Button class="botonSiguiente" ID="btnRedirigir" runat="server" Text="REGRESAR" OnClick="btnRedirigir_Click" />
        </div>
    </div>




</asp:Content>
