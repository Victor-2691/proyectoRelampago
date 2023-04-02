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

                <tbody>
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


    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content" style="background-color: #9dbab5">
                <div class="modal-body">

                    <div class="divClasificacion">
                        <label class="label" for="clasificacion">Clasificación</label>
                        <select class="select" name="clasificacion" id="clasificacion">
                            <option value="Interno">Interno</option>
                            <option value="Externo">Externo</option>
                        </select>
                    </div>


                    <div class="divPestel">

                        <div class="divParte">
                            <div class="divClasificacion">
                                <label class="label" for="politico">Político</label>
                                <select class="select" name="politico" id="politico">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>

                            <div class="divClasificacion">
                                <label class="label" for="tecnologico">Tecnológico</label>
                                <select class="select" name="tecnologico" id="tecnologico">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                        </div>

                        <div class="divParte">
                            <div class="divClasificacion">
                                <label class="label" for="economico">Económico</label>
                                <select class="select" name="economico" id="economico">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                            <div class="divClasificacion">
                                <label class="label" for="ecologico">Ecológico</label>
                                <select class="select" name="ecologico" id="ecologico">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                        </div>

                        <div class="divParte">
                            <div class="divClasificacion social">
                                <label class="label" for="social">Social</label>
                                <select class="select" name="social" id="social">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
                            <div class="divClasificacion">
                                <label class="label" for="legal">Legal</label>
                                <select class="select" name="legal" id="legal">
                                    <option value="1">Positivo</option>
                                    <option value="0">Negativo</option>
                                    <option value="2">N/A</option>
                                </select>
                            </div>
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

</asp:Content>
