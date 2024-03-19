using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TIENDAUPI3.Clases;

namespace TIENDAUPI3
{
    public partial class BODEGA : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();

        }



        protected void bagregar_Click(object sender, EventArgs e)
        {

            if (ClsBodega.Agregar(tnombre.Text) > 0)
            {
                LlenarGrid();
            }

            else
            {
                string errorMessage = "Error al llenar el DataTable: ";
                string script = "<script>alert('" + errorMessage + "');</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", script);
            }

        }

        protected void LlenarGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM bodega", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();

                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Error al llenar el DataTable: " + ex.Message;
                string script = "<script>alert('" + errorMessage + "');</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", script);
            }
            finally
            {

                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            if (ClsBodega.Borrar(Convert.ToInt32(tcodigo.Text)) > 0)
            {
                LlenarGrid();
            }
            else
            {
                string errorMessage = "Error al llenar el DataTable: " ;
                string script = "<script>alert('" + errorMessage + "');</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", script);
            }

            LlenarGrid();

        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            Clsestudiante clsestudiante = new Clsestudiante();
            
            ListadoEstudiante(clsestudiante.crea_estudiantes());
        }
    
        public void ListadoEstudiante(List<Clsestudiante> Lista)
        {
            foreach (var item in Lista)
            {
                Label1.Text = Label1.Text + item.cedula + " " + item.nombre + '\n';

            }
        }
    }
}
