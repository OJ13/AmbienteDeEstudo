<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teachers.aspx.cs" Inherits="DevMediaSchool.Teachers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Teachers</p>
        <br />
        <div style="width:750px; margin:0 auto; padding:0 auto;border:1px solid #CCC; text-align:center">
            <p style="font-weight: bold; text-align:center">Teachers</p> 
            <p style="text-align:center"><asp:Button ID="btnInsert" runat="server" Text="Inserir Novo Professor" OnClick="btnInsert_Click"/></p>
            <asp:GridView ID="gvTeachers" runat="server" Width="500" AllowPaging="true" PageSize="5" AutoGenerateColumns="false" DataKeyNames="TeacherID" HorizontalAlign="Center" OnRowCancelingEdit="gvTeachers_RowCancelingEdit" OnRowEditing="gvTeachers_RowEditing" OnRowUpdating="gvTeachers_RowUpdating" OnRowDeleting="gvTeachers_RowDeleting" OnPageIndexChanging="gvTeachers_PageIndexChanging">
                 <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate><%#Eval("TeacherID") %></ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="SobreNome">
                        <ItemTemplate><%#Eval("TeacherLastName")%></ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSobreNome" runat="server" Text='<%#Eval("TeacherLastName")%>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nome">
                        <ItemTemplate><%#Eval("TeacherFirstName") %></ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNome" runat="server" Text='<%#Eval("TeacherFirstName") %>'>'</asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Data de Inscrição">
                        <ItemTemplate><%#Eval("TeacherDateJoin") %></ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDataInscricao" runat="server" Text='<%#Eval("TeacherDateJoin") %>'>'</asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Departamento">
                        <ItemTemplate><%#Eval("TeacherDepartment") %></ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDepartamento" runat="server" Text='<%#Eval("TeacherDepartment") %>'>'</asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ShowEditButton="true" ButtonType="Link" />
                    <asp:CommandField ShowDeleteButton="true" ButtonType="Link" />

                </Columns>

                <PagerSettings Mode="NumericFirstLast" PageButtonCount="3" FirstPageText="First" LastPageText="Last"/>

            </asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
