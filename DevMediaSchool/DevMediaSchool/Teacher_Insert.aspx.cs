using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Web.Security;

namespace DevMediaSchool
{
    public partial class Teacher_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string Nome = txtNome.Text;
                string Sobrenome = txtSobreNome.Text;
                string Departamento = txtDepartamento.Text;
                string Email = txtEmail.Text;
                string Senha = CriarSenhaHash(txtSenha.Text);

                string connStr = ConfigurationManager.ConnectionStrings["DevMediaSchoolConnectionString"].ConnectionString;

                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("InsertTeacher", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TeacherLastName", Sobrenome);
                cmd.Parameters.AddWithValue("@TeacherFirstName", Nome);
                cmd.Parameters.AddWithValue("@TeacherDepartment", Departamento);
                cmd.Parameters.AddWithValue("@UserEmail", Email);
                cmd.Parameters.AddWithValue("@UserPassword", Senha);

                cmd.ExecuteNonQuery();

                lblMsg.Text = "Professor Inserido com Sucesso!";
                btnInserir.Enabled = false;                
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teachers.aspx");
        }

        private static string CriarSenhaHash(string pwd)
        {
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "SHA1");
            return hashedPwd;
        }
    }
}