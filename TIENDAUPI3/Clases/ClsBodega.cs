using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace TIENDAUPI3.Clases
{
    public class ClsBodega
    {
        public int codigo { get; set; }
        public string Descripcion { get; set; }

        public ClsBodega()
        {
        }

        public ClsBodega( string descripcion)
        {
          Descripcion = descripcion;
        }


        public static int Agregar(string Descripcion)
        {
            int resultado = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                string storedProcedureName = "insertarbodega";

                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@descripcion", Descripcion);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        resultado = 1;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Error al llenar el DataTable: " + ex.Message;
                string script = "<script>alert('" + errorMessage + "');</script>";
                
            }
            finally
            {

                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return resultado;
        }

        public static int Borrar(int codigo)
        {
            int resultado = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                string storedProcedureName = "Borrarbodega";

                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", codigo);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        resultado = 1;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Error al llenar el DataTable: " + ex.Message;
                string script = "<script>alert('" + errorMessage + "');</script>";
               
            }
            finally
            {

                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return resultado;
        }

    }
}