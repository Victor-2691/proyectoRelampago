<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ideas.aspx.cs" Inherits="proyectoRelanpago.Paginas.Ideas" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Estilos/Ideas.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

    <div class="divParrafoEx">
        <p class="parrEx">Digite 3 requerimientos o ideas (trate de ser breve y claro)</p>
    </div>

    <div class="cont">
        <div class="divTitulo">
            <p>Lista de ideas</p>
        </div>

        <div class="contInfo">
            <div class="contIdeas">
                <div>
                    <input class="boton" id="Button1" type="button" value="button" data-toggle="modal" data-target="#exampleModal" />
                </div>

                <div>
                    <input class="boton" id="Button2" type="button" value="button" />
                </div>

                <div>
                    <input class="boton" id="Button3" type="button" value="button" />
                </div>

                <div>
                    <input class="boton" id="Button4" type="button" value="button" />
                </div>

                <div>
                    <input class="boton" id="Button5" type="button" value="button" />
                </div>

                <div>
                    <input class="boton" id="Button6" type="button" value="button" />
                </div>

                <div>
                    <input class="boton" id="Button7" type="button" value="button" />
                </div>

                <div>
                    <input class="boton" id="Button8" type="button" value="button" />
                </div>

                <div>
                    <input class="boton" id="Button9" type="button" value="button" />
                </div>

                <div>
                    <input class="boton" id="Button10" type="button" value="button" />
                </div>
            </div>
        </div>

        <div class="divBoton">
            <asp:Button class="botonGuardar" ID="btnContinuar" runat="server" Text="CONFIRMAR IDEAS" />
        </div>
    </div>

    </form>

    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content" style="background-color: #9dbab5">
                <div class="modal-body">

                    <div class="divTituloIdeas">
                        <p>Ideas</p>
                    </div>

                    <form id="informacion" method="post">
                        <div class="divIdeas">

                            <div>
                                <img src="../Recursos/number1_32.png" alt="Alternate Text" class="number" />
                                <input type="text" class="txt" name="IdeaCaracteristica1" autocomplete="off" placeholder="Idea 1">
                            </div>

                            <div>
                                <img src="../Recursos/number2_32.png" alt="Alternate Text" class="number" />
                                <input type="text" class="txt" name="IdeaCaracteristica1" autocomplete="off" placeholder="Idea 2">
                            </div>

                            <div>
                                <img src="../Recursos/number3_32.png" alt="Alternate Text" class="number" />
                                <input type="text" class="txt" name="IdeaCaracteristica1" autocomplete="off" placeholder="Idea 3">
                            </div>
                        </div>

                        <div class="divBotonGuardar">
                            <input class="botonGuardar" type="button" id="btnGuardar" value="GUARDAR" onclick="guardar('1')">
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <script>

        function guardar(idCaracteristica) {
            var ideas = document.getElementsByName("IdeaCaracteristica" + idCaracteristica)
            var ideasJSON = "";

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
                    ", idCaracteristica:" + JSON.stringify(idCaracteristica) + "}",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (resultado) {
                    if (resultado.d.success === true) {
                    }
                    else {
                        console.log("Error al guardar")
                    }
                }, failure: function (jqXHR, textStatus, errorThrown) {
                    console.log("Status: " + jqXHR.status + "; Error: " + jqXHR.responseText);
                }
            });
        }

    </script>

</asp:Content>
