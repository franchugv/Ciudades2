using Ciudades2.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciudades2
{
    public partial class FormCiudades : Form
    {
        public FormCiudades()
        {
            InitializeComponent();
        }




        // Funcionalidades botones

        private void AgregarProvincia()
        {

            if (string.IsNullOrEmpty(textBoxAgregarProvincia.Text)) throw new Exception("Cadena vacía");


            APIFichero.CrearFichero(textBoxAgregarProvincia.Text);
            CargarProvincias();

            API.UI.MostrarMensaje($"La provincia, {textBoxAgregarProvincia.Text} a sido agregada correctamente.");

            textBoxAgregarProvincia.Text = "";

        }

        private void AgregarCiudad()
        {

            if (string.IsNullOrEmpty(textBoxAgregarCiudad.Text)) throw new Exception("Cadena vacía");

            APIFichero.EscribirFichero(comboBoxListaProvincias.Text ,textBoxAgregarCiudad.Text);

            UI.MostrarMensaje($"La ciudad {textBoxAgregarCiudad.Text} a sido agregada correctamente");

            CargarCiudades();

            textBoxAgregarCiudad.Text = "";
        }



        // Funciones de carga a los comboBox

        private void CargarProvincias()
        {
            comboBoxListaProvincias.Items.Clear();
            comboBoxListaProvincias.Items.AddRange(API.APIFichero.ConsultarDirectorio());
        }

        private void CargarCiudades()
        {
            comboBoxListaCiudades.Items.Clear();
            comboBoxListaCiudades.Items.AddRange(API.APIFichero.ConsultarFichero(comboBoxListaProvincias.Text));
        }

        // Controladores

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos

            Button Opcion = (Button)sender;
            bool esValido = true;
            string MensajeError = "";

            try
            {
                switch (Opcion.Name)
                {

                    case "buttonAgregarProvincia":
                        AgregarProvincia();
                        break;
                    case "buttonAgregarCiudad":
                        AgregarCiudad();
                        break;

                }
            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido)
                {
                    UI.MostrarError(MensajeError);
                }
            }
        }

        private void FormCiudades_Load(object sender, EventArgs e)
        {
            // Recursos

            bool esValido = true;
            string MensajeError = "";

            try
            {
                API.APIFichero.CrearDirectorio();
                CargarProvincias();

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido)
                {
                    UI.MostrarError(MensajeError);
                }
            }
        }

        private void comboBoxListaProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recursos
            bool esValido = true;
            string MensajeError = "";

            // Inicializar objetos

            textBoxAgregarCiudad.Enabled = false;
            comboBoxListaCiudades.Enabled = false;
            buttonAgregarCiudad.Enabled = false;

            comboBoxListaCiudades.Items.Clear();

            try
            {
                CargarCiudades();
            }
            catch(Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido)
                {
                    UI.MostrarError(MensajeError);
                }
                else
                {
                    textBoxAgregarCiudad.Enabled = true;
                    comboBoxListaCiudades.Enabled = true;
                    buttonAgregarCiudad.Enabled = true;
                }
            }
        }



    }
}
