<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagina_login.aspx.cs" Inherits="proyectoRelanpago.Paginas.pagina_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="
https://cdn.jsdelivr.net/npm/sweetalert2@11.7.3/dist/sweetalert2.all.min.js
"></script>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="../Estilos/Login.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/sweetalert2@11.7.3/dist/sweetalert2.min.css" rel="stylesheet"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
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
                            ErrorMessage="Usuario Requerido"  ForeColor="Red" ></asp:RequiredFieldValidator>
                 <asp:TextBox CssClass=""   ID="txt_usuario" runat="server"></asp:TextBox>
                  
                     
                   <asp:RequiredFieldValidator
                            runat="server" 
                            ControlToValidate="txt_contra"
                            ErrorMessage="Contraseña Requerida"  ForeColor="Red" ></asp:RequiredFieldValidator>
                        <asp:TextBox TextMode="Password" ID="txt_contra" runat="server"></asp:TextBox>
                           
                    
                    </div>

                    <div>
                         <asp:Button OnClick="btn_login_Click" CssClass="btn_login"   ID="btn_login" runat="server" Text="INICIAR SESIÓN" />
                    </div>

                    
               
                </div>
              
                 
             
                
      
            </div>
        
        </div>
    </div>
    </form>
</body>
</html>
