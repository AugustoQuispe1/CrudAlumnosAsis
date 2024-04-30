using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosBD;
using System.Data;


namespace Negocio
{
    public class NegAsistencia
    {
        AdminAsis Datosasistencia = new AdminAsis();

        public int abmAsistencia(string accion, Asistencias aLumno)
        {
            return Datosasistencia.abmAsistencia(accion, aLumno);
        }
        public DataSet ListadoAsistencia(string cual)
        {
            return Datosasistencia.listadoAsistencias(cual);
        }
    }
}
