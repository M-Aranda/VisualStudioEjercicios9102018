<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Indice.aspx.cs" Inherits="ejercicio_2.Indice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form action="CalcularDistancia.ashx" method="post">
        <input type="number" name="x1" required/>
        <br>
        <input type="number" name="y1" required/>
        <br>
        <input type="number" name="x2" required/>
        <br>
        <input type="number" name="y2" required/>
        <br>
        <input type="submit" value="Calcular distancia">
        <br>
    </form>
    



</body>
</html>
