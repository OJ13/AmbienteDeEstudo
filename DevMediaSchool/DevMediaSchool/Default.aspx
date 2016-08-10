<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevMediaSchool.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Default</p>
        <br />
        <div style="width:400px; margin: 0 auto; padding:0 auto; border: 1px solid #CCC">
            <p style="font-weight:bold; text-align:center">Menu</p>
            <p style="padding-left:10px"><asp:HyperLink ID="hlTeachers" runat="server" NavigateUrl="~/Teachers.aspx">Professores</asp:HyperLink></p>
        </div>
    </div>
    </form>
</body>
</html>
