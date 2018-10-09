<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Indice.aspx.cs" Inherits="ejercicio3.Indice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="controller/RegistrarNota.ashx" method="post">
    <input type="text" name="nota" required placeholder="Nota">
    <br>
    <input type="submit" value="Registrar nota">
    </form>

     <a href="Estadisticas.aspx">Ver estadisticas</a>


</body>
</html>
