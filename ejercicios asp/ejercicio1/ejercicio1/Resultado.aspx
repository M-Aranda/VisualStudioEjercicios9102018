<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resultado.aspx.cs" Inherits="ejercicio1.Resultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <% int resultado = (int)Session["res"];  %>

    <h1>El resultado de la operacion solicitada es: <%= resultado%> </h1>



</body>
</html>
