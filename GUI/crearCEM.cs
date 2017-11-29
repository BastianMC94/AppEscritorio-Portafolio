using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using RestSharp;
using System.IO;
using APP;
using System.Security.Principal;
using MomentSharp;
using Newtonsoft.Json.Linq;

namespace GUI
{
    public partial class crearCEM : MetroForm
    {
        public crearCEM()
        {
            InitializeComponent();
        }

       
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                //int count = 0;
                //if (txtNombrePrograma.Text.Equals(""))
                //{
                //    MetroMessageBox.Show(this, "Nombre del programa no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    count++;
                //    return;
                //}
                //if (txtDescripcion.Text.Equals("") & txtDescripcion.Text.Equals(""))
                //{
                //    MetroMessageBox.Show(this, "Descripción no válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    count++;
                //    return;
                //}
                //if (txtPaisDestino.Text.Equals("") & txtPaisDestino.Text.Equals(""))
                //{
                //    MetroMessageBox.Show(this, "País de destino no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    count++;
                //    return;
                //}



                long n = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));

                EncargadoCEM cem = new EncargadoCEM();
                cem.Cem_id = Convert.ToString(n);
                cem.Sede = txtInstitucion.Text.Trim();
                cem.Correo = txtCorreo.Text.Trim();
                cem.Clave = txtClave.Text.Trim();
                

                string webAddr = "https://portafoliapi.herokuapp.com/rest/encargadoCEM/crear";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    //string json = "{ \"correo\" : \"cem@gmail.com\", \"clave\" : \"cemclave\" }";
                    string json = "{ \"cem_id\" : \"" + cem.Cem_id
                        + "\", \"intitucion\" : \"" + cem.Sede
                        + "\", \"correo\" : \"" + cem.Correo
                        + "\", \"clave\" : \"" + cem.Clave
                        + "\"}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    if (responseText == "true")
                    {
                        MetroMessageBox.Show(this, "Se ha ingresado satisfactoriamente un encargado CEM al sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Datos Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //MetroMessageBox.Show(this, responseText, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtInstitucion.Text = string.Empty;
                    txtCorreo.Text = string.Empty;
                    txtClave.Text = string.Empty;
                   


                }
            }
            catch (Exception)
            {


            }




            //Preguntar antes de ingresar
            //         if (MetroMessageBox.Show(this, "¿Está seguro de que desea ingresar El siguiente curso?\nNombre del Curso: " + txtNombrePrograma.Text + "\nDescripción: " + txtDescripcion.Text + "\nN° País Destino: " + txtPaisDestino.Text + "\nFecha de Inicio: " + dateTimeFechaInicio.Value + "\nFecha de Termino: " + dateTimeFechaTermino.Value + "\nCupos: " + Convert.ToSingle(txtCupos.Text), "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //{




            //}

        }

    }
}
