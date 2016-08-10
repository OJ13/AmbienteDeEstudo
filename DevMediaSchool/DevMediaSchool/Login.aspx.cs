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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool AutPassWord = false;
            try
            {
                AutPassWord = VerificarPassword(txtEmail.Text, txtPassword.Text);
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message.ToString();
                return;
            }

            if (AutPassWord)
            {
                FormsAuthentication.RedirectFromLoginPage(txtEmail.Text, true);
            }
            else
            {
                lblMsg.Text = "Email / Senha Inválidos!";
            }
        }

        private bool VerificarPassword(string userNameEmail, string passWord)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DevMediaSchoolConnectionString"].ConnectionString;
            bool pass = false;

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("TryLogin", conn);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserEmail", userNameEmail);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                string dbPassWord = reader.GetString(0);                //Pega a senha do usuário vinda do banco

                reader.Close();

                string hsPassWord = CriarPassWord(passWord);            //Pega a senha inserida e modifica o formato para SHA1 hash

                pass = hsPassWord.Equals(dbPassWord);                   //Compara as duas senhas se forem iguais, pass recebe true

            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message.ToString();
            }
            finally
            {
                conn.Close();
            }
            return pass;
        }

        private string CriarPassWord(string pwd)
        {
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "SHA1");         //COdificar Senha, deixar ela em formato Hash

            return hashedPwd;
        }
    }
}