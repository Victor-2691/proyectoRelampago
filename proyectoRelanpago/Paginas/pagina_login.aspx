<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagina_login.aspx.cs" Inherits="proyectoRelanpago.Paginas.pagina_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Estilos/toastr.min.css" rel="stylesheet" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="../Scripts/toastr.min.js"></script>
    <link href="../Estilos/Login.css" rel="stylesheet" />

    <title>Login</title>
</head>
<body>

    <script type="text/javascript">
        function Alerta(mensaje) {
            toastr.options = {
                "closeButton": true,
                "debug": false,
                "newestOnTop": false,
                "progressBar": true,
                "positionClass": "toast-top-full-width",
                "preventDuplicates": true,
                "onclick": null,
                "showDuration": "2000",
                "hideDuration": "4000",
                "timeOut": "5000",
                "extendedTimeOut": "3000",
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut"
            }
            toastr["warning"](mensaje, "Información")
        }
    </script>

    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div id="contenedor">
            <div id="central">
                <div id="login">
                    <div class="contenido">
                        <div class="titulo">
                            <h1>PESTEL</h1>
                        </div>

                        <div>
                            <asp:RequiredFieldValidator
                                runat="server"
                                ControlToValidate="txt_usuario"
                                ErrorMessage="Usuario Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:TextBox CssClass="" ID="txt_usuario" runat="server"></asp:TextBox>


                            <asp:RequiredFieldValidator
                                runat="server"
                                ControlToValidate="txt_contra"
                                ErrorMessage="Contraseña Requerida" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:TextBox TextMode="Password" ID="txt_contra" runat="server"></asp:TextBox>


                        </div>

                        <div>
                            <asp:Button OnClick="btn_login_Click" CssClass="btn_login" ID="btn_login" runat="server" Text="INICIAR SESIÓN" />
                        </div>



                    </div>





                </div>

            </div>
        </div>
    </form>
</body>
</html>
