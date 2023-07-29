<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auxiliar.aspx.cs" Inherits="FormularioWeb5.Auxiliar" %>

<!DOCTYPE html>

<html>

<head>
    <title>Información de Sesión</title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
 
    <style>
        

    </style>
</head> 
<body>
    <form runat="server" class="container">
        <h1 class="mt-5">Información de Sesión</h1>
        <div class="form-group">
            <asp:Label ID="LabelUsuario" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="LabelNombre" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="LabelApellidos" runat="server" Text=""></asp:Label>
        </div>
        <div class="form-group">
            <asp:Button ID="btnMostrarCookie" runat="server" Text="Mostrar Cookie" OnClick="MostrarCookie_Click" CssClass="btn btn-primary btn-custom" />

            <asp:TextBox ID="txtCookieInfo" runat="server" TextMode="MultiLine" Rows="4" Columns="0" ReadOnly="true" CssClass="form-control mt-3" ></asp:TextBox>
   


        </div>
    </form>
</body>
</html>