<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="ejercicio3.Estadisticas" %>
<%@ Import Namespace="ejercicio3.Model" %>  

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>


    <h1>Estadisticas</h1>

    <% DAO_Nota dn = new DAO_Nota(); %>

    <table border="1">



        <tr>
            <td>Cantidad de notas: <%= dn.GetCantNotas() %> </td>
            <td>Cantidad de rojos: <%= dn.GetCantRojos()%> </td>
            <td>Cantidad de azules: <%= dn.GetCantAzules() %> </td>
            <td>Nota mas alta: <%= dn.GetNotaMasAlta() %> </td>
            <td>Nota mas baja: <%=  dn.GetNotaMasBaja()%> </td>
            <td>Cantidad de sietes: <%= dn.GetCantSietes() %> </td>
            <td>Porcentaje de rojos: <%=  dn.GetCantSietes()%> </td>
            <td>Porcentajes de azules: <%= dn.GetCantSietes() %> </td>
            <td>Promedio del curso: <%=  dn.GetPromedioDelCurso()%> </td>

        </tr>
    </table>




</body>
</html>
