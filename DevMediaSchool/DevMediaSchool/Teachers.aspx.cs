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
    public partial class Teachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarGrid();
            }
        }

        public void CarregarGrid()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DevMediaSchoolConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);
            
            conn.Open();

            SqlCommand cmd = new SqlCommand("GetTeachers", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);

            gvTeachers.DataSource = dt;

            gvTeachers.DataBind();
        }

        protected void gvTeachers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvTeachers.EditIndex = -1;
            CarregarGrid();
        }

        protected void gvTeachers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvTeachers.EditIndex = e.NewEditIndex;
            CarregarGrid();
        }

        protected void gvTeachers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int ID = Convert.ToInt32(gvTeachers.DataKeys[e.RowIndex].Value.ToString());

            string sobreNome = ((TextBox)gvTeachers.Rows[e.RowIndex].FindControl("txtSobreNome")).Text;
            string nome = ((TextBox)gvTeachers.Rows[e.RowIndex].FindControl("txtNome")).Text;
            string dataInscricao = ((TextBox)gvTeachers.Rows[e.RowIndex].FindControl("txtDataInscricao")).Text;
            string departamento = ((TextBox)gvTeachers.Rows[e.RowIndex].FindControl("txtDepartamento")).Text;

            string connStr = ConfigurationManager.ConnectionStrings["DevMediaSchoolConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UpdateTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TeacherID", ID);
            cmd.Parameters.AddWithValue("@TeacherLastName", sobreNome);
            cmd.Parameters.AddWithValue("@TeacherFirstName", nome);
            cmd.Parameters.AddWithValue("@TeacherDateJoin", dataInscricao);
            cmd.Parameters.AddWithValue("@TeacherDepartment", departamento);

            cmd.ExecuteNonQuery();

            gvTeachers.EditIndex = -1;
            CarregarGrid();
        }

        protected void gvTeachers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt32(gvTeachers.DataKeys[e.RowIndex].Value.ToString());

            string connStr = ConfigurationManager.ConnectionStrings["DevMediaSchoolConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DeleteTeacher", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TeacherID", ID);
            cmd.Parameters.AddWithValue("@LoginID", -1);

            cmd.ExecuteNonQuery();

            CarregarGrid();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher_Insert.aspx");
        }

        protected void gvTeachers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTeachers.PageIndex = e.NewPageIndex;
            CarregarGrid();
        }

    }
}