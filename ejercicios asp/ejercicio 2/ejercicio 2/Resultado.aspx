<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resultado.aspx.cs" Inherits="ejercicio_2.Resultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <%
        double resultado = (double)Session["distancia"];

     %>

    <h1>La distancia entre los puntos ingresados es de  <%= resultado %></h1>

</body>
</html>
