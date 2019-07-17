using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfEntity.ServiceReference1;

namespace WcfEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_insertar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                Persona p = new Persona();
                p.Nombre = txt_nombres.Text.ToUpper();
                p.Apellidos = txt_apellidos.Text.ToUpper();
                p.Rut = Convert.ToInt32(txt_rut.Text);
                p.DvRut = Convert.ToChar(txt_dvRut.Text);
                p.Edad = Convert.ToInt32(txt_edad.Text);
                p.Direccion = txt_direccion.Text.ToUpper();
                p.Correo = txt_correo.Text;
                Service1Client service = new Service1Client();

                if (service.InsertarPersona(p) == true)
                {

                    MessageBox.Show("Persona Insertada");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se Pudo Ingresar la Persona");
                }
            }
        }



        private void LimpiarCampos()
        {
            txt_nombres.Clear();
            txt_apellidos.Clear();
            txt_rut.Clear();
            txt_dvRut.Clear();
            txt_edad.Clear();
            txt_direccion.Clear();
            txt_correo.Clear();
            txt_Id.Clear();
        }

        private bool ValidarCampos()
        {
            bool validate = true;
            if (txt_nombres.Text == "")
            {
                validate = false;
                errorProvider1.SetError(txt_nombres, "Debe Ingresar Nombre");
            }
            if (txt_apellidos.Text == "")
            {
                validate = false;
                errorProvider1.SetError(txt_apellidos, "Debe Ingresar Apellido");
            }
            if (txt_rut.Text == "")
            {
                validate = false;
                errorProvider1.SetError(txt_rut, "Debe Ingresar Rut");
            }
            if (txt_dvRut.Text == "")
            {
                validate = false;
                errorProvider1.SetError(txt_dvRut, "Debe Ingresar Dv Rut");
            }
            if (txt_edad.Text == "")
            {
                validate = false;
                errorProvider1.SetError(txt_edad, "Debe Ingresar Edad");
            }
            if (txt_direccion.Text == "")
            {
                validate = false;
                errorProvider1.SetError(txt_direccion, "Debe Ingresar Direccion");
            }
            if (txt_correo.Text == "")
            {
                validate = false;
                errorProvider1.SetError(txt_correo, "Debe Ingresar Correo");
            }



            return validate;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txt_nombres, "");
            errorProvider1.SetError(txt_apellidos, "");
            errorProvider1.SetError(txt_rut, "");
            errorProvider1.SetError(txt_dvRut, "");
            errorProvider1.SetError(txt_edad, "");
            errorProvider1.SetError(txt_direccion, "");
            errorProvider1.SetError(txt_correo, "");
        }


        private void Btb_listarPorId_Click(object sender, EventArgs e)
        {
            List<Persona> personasL = new List<Persona>();
            Persona p = new Persona();
            p.Id = Convert.ToInt32(txt_Id.Text);
            Service1Client service = new Service1Client();

            personasL.Add(service.SeleccionarPersonaPorId(p));
            dgv_personas.DataSource = personasL;
            dgv_personas.Columns["Id"].DisplayIndex = 0;
            dgv_personas.Columns["Nombre"].DisplayIndex = 1;
            dgv_personas.Columns["Apellidos"].DisplayIndex = 2;
            dgv_personas.Columns["Rut"].DisplayIndex = 3;
            dgv_personas.Columns["DvRut"].DisplayIndex = 4;
            dgv_personas.Columns["Edad"].DisplayIndex = 5;
            dgv_personas.Columns["Direccion"].DisplayIndex = 6;
            dgv_personas.Columns["Correo"].DisplayIndex = 7;

            txt_nombres.Text = personasL[0].Nombre;
            txt_apellidos.Text = personasL[0].Apellidos;
            txt_rut.Text = personasL[0].Rut.ToString();
            txt_dvRut.Text = personasL[0].DvRut.ToString();
            txt_edad.Text = personasL[0].Edad.ToString();
            txt_direccion.Text = personasL[0].Direccion;
            txt_correo.Text = personasL[0].Correo;




        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
                Persona p = new Persona();
                p.Id = Convert.ToInt32(txt_Id.Text);
                p.Nombre = txt_nombres.Text.ToUpper();
                p.Apellidos = txt_apellidos.Text.ToUpper();
                p.Rut = Convert.ToInt32(txt_rut.Text);
                p.DvRut = Convert.ToChar(txt_dvRut.Text);
                p.Edad = Convert.ToInt32(txt_edad.Text);
                p.Direccion = txt_direccion.Text.ToUpper();
                p.Correo = txt_correo.Text;
                Service1Client service = new Service1Client();

                if (service.ActualizarPersona(p) == true)
                {

                    MessageBox.Show("Persona Actualizadaa");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se Pudo Actualizar la Persona");
                }
            }

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Id = Convert.ToInt32(txt_Id.Text);
            Service1Client service = new Service1Client();

            if (service.EliminarPersona(p) == true)
            {

                MessageBox.Show("Persona Eliminada");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se Pudo Eliminar la Persona");
            }
        }

        private void Btn_listar_todos_Click(object sender, EventArgs e)
        {
            Service1Client service = new Service1Client();

            dgv_personas.DataSource = service.SeleccionarPersonas();
            dgv_personas.Columns["Id"].DisplayIndex = 0;
            dgv_personas.Columns["Nombre"].DisplayIndex = 1;
            dgv_personas.Columns["Apellidos"].DisplayIndex = 2;
            dgv_personas.Columns["Rut"].DisplayIndex = 3;
            dgv_personas.Columns["DvRut"].DisplayIndex = 4;
            dgv_personas.Columns["Edad"].DisplayIndex = 5;
            dgv_personas.Columns["Direccion"].DisplayIndex = 6;
            dgv_personas.Columns["Correo"].DisplayIndex = 7;
        }

        private void Txt_nombres_Validating(object sender, CancelEventArgs e)
        {
            bool isNumeric;
            int i;

            isNumeric = int.TryParse(txt_nombres.Text, out i);

            if (i != 0)
            {
                errorProvider1.SetError(txt_nombres, "Ingrese Un valor en Texto");
            }
            else
            {
                errorProvider1.SetError(txt_nombres, "");
            }
        }

        private void Txt_apellidos_Validating(object sender, CancelEventArgs e)
        {
            bool isNumeric;
            int i;

            isNumeric = int.TryParse(txt_apellidos.Text, out i);

            if (i != 0)
            {
                errorProvider1.SetError(txt_apellidos, "Ingrese Un valor en Texto");
            }
            else
            {
                errorProvider1.SetError(txt_apellidos, "");
            }
        }

        private void Txt_rut_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txt_rut.Text, out num))
            {
                errorProvider1.SetError(txt_rut, "Ingrese Un valor en Numeros");
            }
            else
            {
                errorProvider1.SetError(txt_rut, "");
            }
        }

        private void Txt_edad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txt_edad.Text, out num))
            {
                errorProvider1.SetError(txt_edad, "Ingrese Un valor en Numeros");
            }
            else
            {
                errorProvider1.SetError(txt_edad, "");
            }
        }

        private void Txt_direccion_Validating(object sender, CancelEventArgs e)
        {
            bool isNumeric;
            int i;

            isNumeric = int.TryParse(txt_direccion.Text, out i);

            if (i != 0)
            {
                errorProvider1.SetError(txt_direccion, "Ingrese Un valor en Texto");
            }
            else
            {
                errorProvider1.SetError(txt_direccion, "");
            }
        }

        private void Txt_correo_Validating(object sender, CancelEventArgs e)
        {
            bool isNumeric;
            int i;

            isNumeric = int.TryParse(txt_correo.Text, out i);

            if (i != 0)
            {
                errorProvider1.SetError(txt_correo, "Ingrese Un valor en Texto");
            }
            else
            {

                if (txt_correo.Text.Contains("@"))
                {
                    errorProvider1.SetError(txt_correo, "");
                }
                else
                {
                    errorProvider1.SetError(txt_correo, "Ingrese Un Correo Valido");
                }

            }
        }

        private void Txt_dvRut_Validating(object sender, CancelEventArgs e)
        {
            if (txt_dvRut.Text == "")
            {
                errorProvider1.SetError(txt_dvRut, "Debe Ingresar Dv Rut");
            }
            else
            {
                errorProvider1.SetError(txt_dvRut, "");
            }
        }
    }
}
