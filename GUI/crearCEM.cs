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

        private void txtCupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int count = 0;
            //    if (txtNombrePrograma.Text.Equals(""))
            //    {
            //        MetroMessageBox.Show(this, "Nombre del programa no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        count++;
            //        return;
            //    }
            //    if (txtDescripcion.Text.Equals("") & txtDescripcion.Text.Equals(""))
            //    {
            //        MetroMessageBox.Show(this, "Descripción no válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        count++;
            //        return;
            //    }
            //    if (txtPaisDestino.Text.Equals("") & txtPaisDestino.Text.Equals(""))
            //    {
            //        MetroMessageBox.Show(this, "País de destino no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        count++;
            //        return;
            //    }



            //    long n = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
                
            //    dateTimeFechaInicio.Format = DateTimePickerFormat.Custom;
            //    dateTimeFechaInicio.CustomFormat = "yyyy-MM-dd";

            //    dateTimeFechaTermino.Format = DateTimePickerFormat.Custom;
            //    dateTimeFechaTermino.CustomFormat = "yyyy-MM-dd";

            //    ProgramaInter pro = new ProgramaInter();
            //    pro.Programa_id = Convert.ToString(n);
            //    pro.Nombre_programa = txtNombrePrograma.Text.Trim();
            //    pro.Descripcion = txtDescripcion.Text.Trim();
            //    pro.Pais_destino = txtPaisDestino.Text.Trim();
            //    pro.Fecha_inicio = dateTimeFechaInicio.Text.Trim();
            //    pro.Fecha_termino = dateTimeFechaTermino.Text.Trim();
            //    pro.Cupos = Convert.ToInt32(txtCupos.Text.Trim());
            //    pro.Programa_asignado = '0';
            //    pro.Cel_id = null;
            //    pro.Cem_id = "cem_id";

            //    string webAddr = "https://portafoliapi.herokuapp.com/rest/programa/crear";

            //    var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            //    httpWebRequest.ContentType = "application/json; charset=utf-8";
            //    httpWebRequest.Method = "POST";

            //    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //    {
            //        //string json = "{ \"correo\" : \"cem@gmail.com\", \"clave\" : \"cemclave\" }";
            //        string json = "{ \"programa_id\" : \"" + pro.Programa_id
            //            + "\", \"nombre_programa\" : \"" + pro.Nombre_programa
            //            + "\", \"descripcion\" : \"" + pro.Descripcion
            //            + "\", \"pais_destino\" : \"" + pro.Pais_destino
            //            + "\", \"fecha_inicio\" : \"" + pro.Fecha_inicio
            //            + "\", \"fecha_termino\" : \"" + pro.Fecha_termino
            //            + "\", \"cupos\" : \"" + pro.Cupos
            //            + "\", \"programa_asignado\" : \"" + pro.Programa_asignado
            //            + "\", \"cel_id\" : \"" + pro.Cel_id
            //            + "\", \"cem_id\" : \"" + pro.Cem_id + "\"}";
                    
            //        streamWriter.Write(json);
            //        streamWriter.Flush();
            //    }
            //    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //    {
            //        var responseText = streamReader.ReadToEnd();
            //        if (responseText == "true")
            //        {
            //            MetroMessageBox.Show(this, "Se ha ingresado satisfactoriamente el programa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MetroMessageBox.Show(this, "Datos Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        //MetroMessageBox.Show(this, responseText, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        txtNombrePrograma.Text = string.Empty;
            //        txtDescripcion.Text = string.Empty;
            //        txtPaisDestino.Text = string.Empty;
            //        txtCupos.Text = string.Empty;


            //    }
            //}
            //catch (Exception)
            //{


            //}




            //Preguntar antes de ingresar
            //         if (MetroMessageBox.Show(this, "¿Está seguro de que desea ingresar El siguiente curso?\nNombre del Curso: " + txtNombrePrograma.Text + "\nDescripción: " + txtDescripcion.Text + "\nN° País Destino: " + txtPaisDestino.Text + "\nFecha de Inicio: " + dateTimeFechaInicio.Value + "\nFecha de Termino: " + dateTimeFechaTermino.Value + "\nCupos: " + Convert.ToSingle(txtCupos.Text), "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //{




            //}

        }
        
        
    }
}
