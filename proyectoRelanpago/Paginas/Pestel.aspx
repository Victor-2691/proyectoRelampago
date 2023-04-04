<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pestel.aspx.cs" Inherits="proyectoRelanpago.Paginas.Pestel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Estilos/Pestel.css" rel="stylesheet" />

    <div class="cont">

        <div class="divTitulo">
            <p>PESTEL</p>
        </div>

        <div>
            <table>

                <thead>
                    <tr class="encabezados">
                        <th>Factores</th>
                        <th>Clasificación</th>
                    </tr>
                </thead>

                <tbody runat="server" id="factores">                   
                </tbody>

            </table>
        </div>

        <div class="divBoton">
             <input class="botonSiguiente" type="button" value="VER RESUMEN" onclick="validar();"/>               
        </div>
    </div>

    <div runat="server" id="divModals">
    </div>
   
    <script>

        function guardar(idFactor, idHojaResultado, idOpc) {

            const array = ["Negativo", "Positivo"];
            const clasificacion = document.getElementById("clasificacion" + array[idOpc] + idFactor).value;
            const politico = document.getElementById("politico" + array[idOpc] + idFactor).value;
            const economico = document.getElementById("economico" + array[idOpc] + idFactor).value;
            const social = document.getElementById("social" + array[idOpc] + idFactor).value;
            const tecnologico = document.getElementById("tecnologico" + array[idOpc] + idFactor).value;
            const ecologico = document.getElementById("ecologico" + array[idOpc] + idFactor).value;
            const legal = document.getElementById("legal" + array[idOpc] + idFactor).value;
            const justificacion = document.getElementById("comentarioFactor" + array[idOpc] + idFactor).value;

            const txtID = document.getElementById("IDPestel" + array[idOpc] + idFactor);
            const id = document.getElementById("IDPestel" + array[idOpc] + idFactor).value;

            const modalCerrar = "#Factor" + array[idOpc] + idFactor;
                                    
            $.ajax({
                url: "Pestel.aspx/guardarPestel",
                data: "{idFactor:" + JSON.stringify(idFactor) +
                    ", tipoFactor:" + JSON.stringify(idOpc) +
                    ", clasificacion:" + JSON.stringify(clasificacion) +
                    ", politico:" + JSON.stringify(politico) +
                    ", economico:" + JSON.stringify(economico) +
                    ", social:" + JSON.stringify(social) +
                    ", tecnologico:" + JSON.stringify(tecnologico) +
                    ", ecologico:" + JSON.stringify(ecologico) +
                    ", legal:" + JSON.stringify(legal) +
                    ", justificacion:" + JSON.stringify(justificacion) +
                    ", idHojaResultado:" + JSON.stringify(idHojaResultado) +
                    ", idPestel:" + JSON.stringify(id) + "}",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (resultado) {
                    if (resultado.d.success === true) {
                        var idModificar = resultado.d.id;
                        txtID.value = idModificar;
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
                url: "Pestel.aspx/validarDatos",
                data: {},
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (resultado) {
                    if (resultado.d.success === true) {
                        window.location.href = "../Paginas/ResumenPestel.aspx";
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
