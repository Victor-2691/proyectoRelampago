<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Caracteristicas.aspx.cs" Inherits="proyectoRelanpago.Paginas.Caracteristicas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Estilos/Caracteristicas.css" rel="stylesheet" />

    <div class="cont">
        <div class="divParrafoEx">
            <p class="parrEx">Digite 10 características prioritarias que han determinado </p>
        </div>

        <div class="contInfo">
            <div class="contCaracteristicas">
                <div>
                    <img src="../Recursos/number1_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac1" runat="server" placeholder="Característica 1"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number2_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac2" runat="server" placeholder="Característica 2"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number3_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac3" runat="server" placeholder="Característica 3"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number4_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac4" runat="server" placeholder="Característica 4"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number5_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac5" runat="server" placeholder="Característica 5"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number6_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac6" runat="server" placeholder="Característica 6"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number7_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac7" runat="server" placeholder="Característica 7"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number8_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac8" runat="server" placeholder="Característica 8"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number9_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac9" runat="server" placeholder="Característica 9"></asp:TextBox>
                </div>

                <div>
                    <img src="../Recursos/number10_32.png" alt="Alternate Text" class="number" />
                    <asp:TextBox class="txt" ID="txtCarac10" runat="server" placeholder="Característica 10"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="divBoton">
              <asp:Button OnClick="btnGuardar_Click"
                class="botonGuardar" ID="btnGuardar" runat="server" Text="CONFIRMAR CARACTERÍSTICAS"   />
        </div>        
    </div>

</asp:Content>
