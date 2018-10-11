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

    <% DAO_Nota dn = new DAO_Nota();


        int cantNotas = dn.GetCantNotas();
        int cantAzules = dn.GetCantAzules();
        int cantRojos = dn.GetCantRojos();

        float porcRojos = ((float)cantRojos / cantNotas) * 100;
        float porcAzules = ((float)cantAzules / cantNotas) * 100;

        


        %>



    <table border="1">



        <tr>
            <td>Cantidad de notas: <%= cantNotas %> </td>
            <td>Cantidad de rojos: <%= cantRojos%> </td>
            <td>Cantidad de azules: <%= cantAzules %> </td>
            <td>Nota mas alta: <%= dn.GetNotaMasAlta() %> </td>
            <td>Nota mas baja: <%=  dn.GetNotaMasBaja()%> </td>
            <td>Cantidad de sietes: <%= dn.GetCantSietes() %> </td>
            <td>Porcentaje de rojos: <%=  Math.Round(porcRojos)%> </td>
            <td>Porcentajes de azules: <%= Math.Round(porcAzules) %> </td>
            <td>Promedio del curso: <%=  dn.GetPromedioDelCurso()%> </td>

        </tr>
    </table>




</body>
</html>
