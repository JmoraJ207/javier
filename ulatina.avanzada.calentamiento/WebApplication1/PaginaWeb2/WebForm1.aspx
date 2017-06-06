<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 385px">
    <form id="FRMCAlentamiento" runat="server" title="Forma de Prueba">
        <div style="height: 314px" title="Hello World">
            hello world<br />
&nbsp;<asp:Calendar ID="CLDFechadeentrada" runat="server" OnSelectionChanged="CLDFechadeentrada_SelectionChanged"></asp:Calendar>
            <asp:Label ID="LBLBFechaseleccionada" runat="server" Text="Label"></asp:Label>
            <br />
            Fecha seleccionada
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged" Width="135px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
