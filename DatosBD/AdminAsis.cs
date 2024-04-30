using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBD
{
    public class AdminAsis : DatosConexion
    {
        public int abmAsistencia(string accion, Asistencias aLumno)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = $"insert into Asistencia (DNI,Fecha,Asistencia) values ('{aLumno.DNI}','{aLumno.Fecha}','{aLumno.Asistencia}',);";

            }

            if (accion == "Modificar")
            {
                orden = $"update Asistencia SET DNI='{aLumno.DNI}',Fecha='{aLumno.Fecha}',Asistencia={aLumno.Asistencia},;";
            }
            if (accion == "Borrar")
            {
                orden = "Delete from Asistencia WHERE ID=" + aLumno.id + "";
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


        public DataSet listadoAsistencias(string cual)
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
