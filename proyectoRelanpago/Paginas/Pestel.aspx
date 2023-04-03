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
                    <tr>
                        <td>Programas técnicos o capacitaciones rápidas con mercado laboral</td>
                        <td>
                            <button class="botonModal" type="button" data-toggle="modal" data-target="#exampleModal">
                                <img class="imgPestel" src="../Recursos/signoMas_32.png" alt=""></button>
                        </td>
                    </tr>
                    <tr>
                        <td>Programas técnicos o capacitaciones rápidas con mercado laboral</td>
                        <td>
                            <img class="imgPestel" src="../Recursos/signoMas_32.png" alt=""></td>
                    </tr>
                    <tr>
                        <td>Programas técnicos o capacitaciones rápidas con mercado laboral</td>
                        <td>
                            <img class="imgPestel" src="../Recursos/signoMas_32.png" alt=""></td>
                    </tr>
                </tbody>

            </table>
        </div>

        <div class="divBoton">
            <asp:Button class="botonSiguiente" ID="btnContinuar" runat="server" Text="VER RESUMEN" />
        </div>
    </div>

    <div runat="server" id="divModals">
    </div>

    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content" style="background-color: #9dbab5">
                <div class="modal-body">

                    <div class="divClasificacion">
                        <label class="label" for="clasificacion">Clasificación</label>
                        <select class="select" name="clasificacionPositivo" id="clasificacion">
                            <option value="Interno">Interno</option>
                            <option value="Externo">Externo</option>
                        </select>
                    </div>

                    <div class="divPestel">
                        <div class="divParte">
                            <div class="divClasificacion">
                                <label class="label" for="politico">Político</label>
                                <select class="select" name="politicoPositivo" id="politico">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>

                            <div class="divClasificacion">
                                <label class="label" for="tecnologico">Tecnológico</label>
                                <select class="select" name="tecnologicoPositivo" id="tecnologico">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                        </div>

                        <div class="divParte">
                            <div class="divClasificacion">
                                <label class="label" for="economico">Económico</label>
                                <select class="select" name="economicoPositivo" id="economico">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                            <div class="divClasificacion">
                                <label class="label" for="ecologico">Ecológico</label>
                                <select class="select" name="ecologicoPositivo" id="ecologico">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                        </div>

                        <div class="divParte">
                            <div class="divClasificacion social">
                                <label class="label" for="social">Social</label>
                                <select class="select" name="socialPositivo" id="social">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                            <div class="divClasificacion">
                                <label class="label" for="legal">Legal</label>
                                <select class="select" name="legalPositivo" id="legal">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                        </div>

                    </div>

                    <div class="divClasificacion">
                        <label class="label">Justificar clasificación (opcional)</label>
                        <textarea class="comentario" name="comentario"></textarea>
                    </div>

                    <div class="divBotonGuardar">
                        <input class="botonGuardar" type="button" id="btnGuardar" value="GUARDAR">
                    </div>

                </div>
            </div>
        </div>
    </div>

    <script>

        function guardar(idFactor, idHojaResultado, idOpc) {

            const array = ["Positivo", "Negativo"];
            const clasificacion = document.getElementById("clasificacion" + array[idOpc] + idFactor).value;
            const politico = document.getElementById("politico" + array[idOpc] + idFactor).value;
            const economico = document.getElementById("economico" + array[idOpc] + idFactor).value;
            const social = document.getElementById("social" + array[idOpc] + idFactor).value;
            const tecnologico = document.getElementById("tecnologico" + array[idOpc] + idFactor).value;
            const ecologico = document.getElementById("ecologico" + array[idOpc] + idFactor).value;
            const legal = document.getElementById("legal" + array[idOpc] + idFactor).value;
            const justificacion = document.getElementById("comentarioFactor" + array[idOpc] + idFactor).value;


            alert(clasificacion + "," + politico + "," + economico + "," + social + "," + tecnologico + "," + ecologico + "," + legal + "," + justificacion);




            
            //var modalCerrar = "#Caracteristica" + idCaracteristica;



            //var txtIDs = document.getElementById("IDCaracteristica" + idCaracteristica);
            //var ids = document.getElementById("IDCaracteristica" + idCaracteristica).value;

            $.ajax({
                url: "Pestel.aspx/guardarPestel",
                data: "{clasificacion:" + JSON.stringify(clasificacion) +
                    ", politico:" + JSON.stringify(politico) +
                    ", economico:" + JSON.stringify(economico) +
                    ", social:" + JSON.stringify(social) +
                    ", tecnologico:" + JSON.stringify(tecnologico) +
                    ", ecologico:" + JSON.stringify(ecologico) +
                    ", legal:" + JSON.stringify(legal) +
                    ", justificacion:" + JSON.stringify(justificacion) + "}",
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

    </script>

</asp:Content>
