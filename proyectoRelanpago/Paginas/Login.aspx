<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="proyectoRelanpago.Paginas.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Estilos/Login.css" rel="stylesheet" />
    

    <div id="contenedor">
        <div id="central">
            <div id="login">
                <div class="centrar_icono">
                    <div class="titulo">
                        <h1>PESTEL</h1>
                    </div>
                </div>
                <asp:TextBox CssClass=""   ID="txt_usuario" runat="server"></asp:TextBox>
                <asp:TextBox TextMode="Password" ID="txt_contra" runat="server"></asp:TextBox>
                <asp:Button CssClass="btn_login"   ID="btn_login" runat="server" Text="INICIAR SESIÓN" />
      
                <div class="pie-form">

                </div>
            </div>
            <div class="inferior">

            </div>
        </div>
    </div>



</asp:Content>
