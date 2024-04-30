using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DatosBD
{
    public class DatosConexion
    {
        protected SqlConnection conexion;
        protected string cadenaConexion = @"Data Source=DESKTOP-O42FF5U;Initial Catalog=Alumnos;Integrated Security=True;Trust Server Certificate=True";
        public DatosConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}
