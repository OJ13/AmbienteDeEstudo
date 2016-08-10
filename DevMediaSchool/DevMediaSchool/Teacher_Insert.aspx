<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teacher_Insert.aspx.cs" Inherits="DevMediaSchool.Teacher_Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Teacher_Insert</p>
        <br />
        <div style="width:750px; margin: 0 auto; padding: 0 auto; border:1px solid #CCC; text-align:center">
            <p style="font-weight:bold; text-align:center">Professor Inserir</p>
            <p><b>Nome: </b><asp:TextBox ID="txtNome" runat="server" Width="600"></asp:TextBox></p>
            <p><b>Sobrenome: </b><asp:TextBox ID="txtSobreNome" runat="server" Width="600"></asp:TextBox></p>
            <p><b>Departamento: </b><asp:TextBox ID="txtDepartamento" runat="server" Width="594"></asp:TextBox></p>
            <p><b>Email: </b><asp:TextBox ID="txtEmail" runat="server" Width="620"></asp:TextBox></p>
            <p><b>Senha: </b><asp:TextBox ID="txtSenha" runat="server" Width="200"></asp:TextBox></p>
            <p><asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />&nbsp;&nbsp;
                <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click"/>
            </p>
            <p style="text-align:left; padding-left:20px"><asp:Label ID="lblMsg" runat="server" Text=""></asp:Label></p>
        </div>
    </div>
    </form>
</body>
</html>
