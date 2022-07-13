<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01WstepAjax.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.6.0.min.js"></script>
    <script src="DefaultJS.js"></script>
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:Button ID="btnPolicz" OnClick="btnPolicz_Click" runat="server" Text="Button" />
       
        <asp:TextBox ID="txtLiczba1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLiczba2" runat="server"></asp:TextBox>
        
        <asp:Label ID="lblWynik" runat="server" Text="Label"></asp:Label>


        <br />

        <input type="button" value="Policz" id="btnPoliczhtml" />
        <input type="text" id="txtLiczba1html" /> 
        <input type="text" id="txtLiczba2html" /> 

        <span id="lblWynikhtml"></span>



    </form>
</body>
</html>
