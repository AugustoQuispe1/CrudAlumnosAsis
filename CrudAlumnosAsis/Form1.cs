using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAlumnosAsis
{
    public partial class Form1 : Form
    {
        private Alumno alumno = new Alumno();
        private Asistencias asistencias = new Asistencias();
        private NegAsistencia neg = new NegAsistencia();
        private NegAlumno negalumno = new NegAlumno();
        DataSet ds = new DataSet();
        public DataTable DT {get;set;} = new DataTable();

        public Form1()
        {
            InitializeComponent();

            dataGrid.ColumnCount = 4;
            dataGrid.Columns[1].HeaderText = "Nombre";
            dataGrid.Columns[2].HeaderText = "Apellido";
            dataGrid.Columns[3].HeaderText = "DNI";
            dataGrid.Columns[1].Width = 100;
            dataGrid.Columns[2].Width = 100;
            dataGrid.Columns[3].Width = 100;

            dataasistencia.ColumnCount = 3;
            dataasistencia.Columns[1].HeaderText = "DNI";
            dataasistencia.Columns[2].HeaderText = "Fecha";
            dataasistencia.Columns[3].HeaderText = "Asistencia";
            dataasistencia.Columns[1].Width = 80;
            dataasistencia.Columns[2].Width = 80;
            dataasistencia.Columns[3].Width = 80;




            LlenarAlum();

        }

        private void LlenarAlum()
        {
            dataGrid.Rows.Clear();

            ds = negalumno.ListadoAlumno("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGrid.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2]);
                        
                }

            }
            else
            {
                MessageBox.Show("No hay alumnos cargados en el sistema");
            }
        }

        private void LlenarAsistencia()
        {
            dataasistencia.Rows.Clear();
            ds = neg.ListadoAsistencia("Todos");


            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataasistencia.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() );
                }
            }
        }

        private void Bt_Cargar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            string cuil = Txt_DNI.Text.Trim();

            if (Txt_DNI.Text != "" && Txt_Nombre.Text != "" && Txt_Apellido.Text != "")
            {
                if (cuil.Length == 8 && cuil.All(char.IsDigit))
                {
                    ds = negalumno.ListadoAlumno(Txt_DNI.Text);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            MessageBox.Show("No se pudo cargar el alumno en el sistema porque ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        CargarAlumno();
                        nGrabados = negalumno.abmAlumno("Alta", alumno);
                        if (nGrabados == -1)
                        {
                            MessageBox.Show("No se puede grabar el alumno en el sistema");

                        }
                        else
                        {
                            MessageBox.Show("Se pudo cargar el alumno al sistema con exito");
                            LlenarAlum();
                            LimpiarPantalla();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un DNI valido de 8 números.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }

        private void CargarAlumno()
        {
            alumno.Nombre = Txt_Nombre.Text;
            alumno.Apellido = Txt_Apellido.Text;
            alumno.DNI = int.Parse(Txt_DNI.Text);
        }

        private void cargarAsistencia()
        {
            asistencias.DNI = int.Parse(Txt_DNI_Asis.Text);
            asistencias.Asistencia = rButton_Asis.Checked;
            asistencias.Fecha = dateTime_fecha.Value;
        }

        private void LimpiarPantalla()
        {
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_DNI.Text = "";
            Txt_DNI_Asis.Text = "";
        }

        private void Bt_Borrar_Click(object sender, EventArgs e)
        {
            string DATO = Txt_DNI.Text;

            if(DATO != "")
            {
                ds = neg.ListadoAsistencia(Txt_DNI.Text);

                if (ds.Tables[0].Rows.Count > 0 )
                {
                    foreach(DataRow dr in ds.Tables[0].Rows)
                    {
                        MessageBox.Show("No se pudo borrar el alumno porque no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                }
                else
                {
                    alumno.DNI = Convert.ToInt32(Txt_DNI.Text);
                    negalumno.abmAlumno("Borrar", alumno);

                    MessageBox.Show("Se pudo borrar el alumno con exito");
                    LlenarAlum();
                    LimpiarPantalla();

                }
            }
        }

        private void Bt_Modificar_Click(object sender, EventArgs e)
        {
            int nResultado = -1;

            CargarAlumno();
            nResultado = negalumno.abmAlumno("Modificar", alumno);
            if (nResultado != -1)
            {
                MessageBox.Show("Se realizo la modificacion con exito");
                LlenarAlum();
                LimpiarPantalla();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la modifiacion del alumno");
            }
        }

        private void Bt_Cargar_Asis_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //.
            string cuil = Txt_DNI_Asis.Text;

            if (Txt_DNI_Asis.Text != "")
            {
                if (cuil.Length == 8 && cuil.All(char.IsDigit))
                {
                    ds = negalumno.ListadoAlumno(Txt_DNI.Text);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            cargarAsistencia();
                            nGrabados = neg.abmAsistencia("Alta", asistencias);
                            if (nGrabados == -1)
                            {
                                MessageBox.Show("No se pudo cargar la asistencia del alumno en el sistema");

                            }
                            else
                            {
                                MessageBox.Show("Se pudo cargar la asistencia del alumno con extio");
                                LlenarAsistencia();
                                LimpiarPantalla();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La asistencia del alumno no existe", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI valido porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_Borrar_Asis_Click(object sender, EventArgs e)
        {
            string DATO = Txt_DNI_Asis.Text;

            if(DATO != "")
            {
                asistencias.DNI = Convert.ToInt32(Txt_DNI_Asis.Text);

                neg.abmAsistencia("Borrar", asistencias);

                MessageBox.Show("Se pudo borrar la asistencia con exito");
                LlenarAsistencia();
                LimpiarPantalla();

            }
        }

        private void Bt_Modificar_Asis_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            cargarAsistencia();

            nResultado = neg.abmAsistencia("Modificar", asistencias);

            if(nResultado != -1)
            {
                MessageBox.Show("La asistencia fue modificada con exito");
                LlenarAsistencia();
                LimpiarPantalla();
            }
        }
    }
}
