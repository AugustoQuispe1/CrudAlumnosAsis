using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DatosBD
{
    public class AdminAlumno : DatosConexion
    {
        public int abmAlumno(string accion, Alumno aLumno)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = $"insert into asistencias (Nombre,Apellido,DNI) values ({aLumno.Nombre},'{aLumno.Apellido}','{aLumno.DNI}');";

            }

            if (accion == "Modificar")
            {
                orden = $"update asistencias SET Nombre='{aLumno.Nombre}',Apellido='{aLumno.Apellido}'  where DNI={aLumno.DNI};";
            }
            if (accion == "Borrar")
            {
                orden = "Delete from asistencias WHERE DNI=" + aLumno.DNI + "";
            }
            if (accion == "Buscar")
            {
                orden = $"SELECT * FROM asistencias WHERE DNI=" + aLumno.DNI + "";
            }

            
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de alumno", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoAlumno(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                orden = "select * from Asistencia where DNI = " + cual + ";";
            }

            else
            {
                orden = "select * from Asistencia;";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Alumno", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
