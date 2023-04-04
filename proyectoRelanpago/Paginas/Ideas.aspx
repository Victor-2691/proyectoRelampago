<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ideas.aspx.cs" Inherits="proyectoRelanpago.Paginas.Ideas" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Estilos/Ideas.css" rel="stylesheet" />

    <div class="divParrafoEx">
        <p class="parrEx">Digite 3 requerimientos o ideas (trate de ser breve y claro)</p>
    </div>

    <div class="cont">
        <div class="divTitulo">
            <p>Lista de ideas</p>
        </div>

        <div class="contInfo">
            <div class="contIdeas" runat="server" id="divCaracteristicas">
            </div>
        </div>

        <div class="divBoton">
            <input class="botonGuardar" type="button" value="CONFIRMAR IDEAS" onclick="validar();"/>           
        </div>
    </div>

    <div runat="server" id="divModals">
    </div>

    <script>

        function guardar(idCaracteristica, idHojaResultado) {
            var ideas = document.getElementsByName("IdeaCaracteristica" + idCaracteristica);
            var ideasJSON = "";
            var modalCerrar = "#Caracteristica" + idCaracteristica;
            var txtIDs = document.getElementById("IDCaracteristica" + idCaracteristica);
            var ids = document.getElementById("IDCaracteristica" + idCaracteristica).value;

            for (var i = 0; i < ideas.length; i++) {
                if (i != ideas.length - 1) {
                    ideasJSON = ideasJSON + ideas[i].value + ",";
                }
                else {
                    ideasJSON = ideasJSON + ideas[i].value;
                }
            }

            $.ajax({
                url: "Ideas.aspx/guardarIdeas",
                data: "{ideas:" + JSON.stringify(ideasJSON) +
                    ", idCaracteristica:" + JSON.stringify(idCaracteristica) +
                    ", idHojaResultado:" + JSON.stringify(idHojaResultado) +
                    ", idsRaw:" + JSON.stringify(ids) + "}",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (resultado) {
                    if (resultado.d.success === true) {
                        var idsModificar = resultado.d.ids;
                        txtIDs.value = idsModificar;
                        $(modalCerrar).modal("hide");
                    }
                    else {
                        console.log("Error al guardar");
                    }
                }, failure: function (jqXHR, textStatus, errorThrown) {
                    console.log("Status: " + jqXHR.status + "; Error: " + jqXHR.responseText);
                }
            });
        }

        function validar() {
            $.ajax({
                url: "Ideas.aspx/validarDatos",
                data: {},
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (resultado) {
                    if (resultado.d.success === true) {
                        window.location.href = "../Paginas/Factores.aspx";                        
                    }
                    else {
                        console.log("Error al validar datos");
                    }
                }, failure: function (jqXHR, textStatus, errorThrown) {
                    console.log("Status: " + jqXHR.status + "; Error: " + jqXHR.responseText);
                }
            });
        }

    </script>

</asp:Content>
