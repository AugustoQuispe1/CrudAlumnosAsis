using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosBD;


namespace Negocio
{
    public class NegAlumno
    {
        AdminAlumno DatosAlumno = new AdminAlumno();

        public int abmAlumno(string accion, Alumno aLumno)
        {
            return DatosAlumno.abmAlumno(accion, aLumno);
        }
        public DataSet ListadoAlumno(string cual)
        {
            return DatosAlumno.listadoAlumno(cual);
        }
    }
}
