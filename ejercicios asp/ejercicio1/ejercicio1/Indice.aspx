<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Indice.aspx.cs" Inherits="ejercicio1.Indice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
        <form action="Calculadora.ashx" method="post">
        <input type="text" name="primerNumero" placeholder="N 1:" required />
        <br>
        <input type="text" name="segundoNumero" placeholder= "N 2" required />
        <br>
        <input type="text" name="operacion" palceholder="que hacer?" required />
        <br>
        <input type="submit" value="calcular">
    </form>
</body>
</html>
