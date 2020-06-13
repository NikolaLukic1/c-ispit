<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
</head>
<body>
    <div class="card-header-pills bg-dark text-white text-center">
        <h2>Zadatak 4</h2>
    </div>
    <div class="login d-flex flex-column justify-content-center align-items-center" style="text-align:center">
    <form id="form1" runat="server"  style="width:50%;text-align:center">
    <div class="form-group" style="text-align:center">
        <asp:Label ID="lbl_broj"  runat ="server">Unesite broj:</asp:Label>
        <asp:TextBox ID="txt_Broj" runat ="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="btn_Submit" runat="server" CssClass="btn btn-primary" OnClick="btn_Submit_Click" Text="Izračunaj"/>
    </div>
        <asp:Label ID="lbl_tekstRes"  runat ="server">Rezultat:</asp:Label>
        <asp:Label ID="lbl_result"  runat ="server"></asp:Label>

  
    </form>
    </div>
</body>
</html>
