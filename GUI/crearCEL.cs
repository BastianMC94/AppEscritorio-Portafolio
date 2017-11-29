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
    public partial class crearCEL : MetroForm
    {
        public crearCEL()
        {
            InitializeComponent();
        }

		private void btnCrearCEL_Click(object sender, EventArgs e)
		{
            try
            {
   
            long m = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));

            EncargadoCEL cel = new EncargadoCEL();
            cel.Cel_id = Convert.ToString(m);
            cel.Institucion = txtSede.Text.Trim();
            cel.Correo = txtCorreo.Text.Trim();
            cel.Pais = txtPais.Text.Trim();
            cel.Clave = txtClave.Text.Trim();


            string webAddr = "https://portafoliapi.herokuapp.com/rest/encargadoCEL/crear";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                //string json = "{ \"correo\" : \"cem@gmail.com\", \"clave\" : \"cemclave\" }";
                string json = "{ \"cel_id\" : \"" + cel.Cel_id
                    + "\", \"institucion\" : \"" + cel.Institucion
                    + "\", \"correo\" : \"" + cel.Correo
                    + "\", \"pais\" : \"" + cel.Pais
                    + "\", \"clave\" : \"" + cel.Clave
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
                    MetroMessageBox.Show(this, "Se ha ingresado satisfactoriamente un encargado CEL al sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Datos Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //MetroMessageBox.Show(this, responseText, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSede.Text = string.Empty;
                txtPais.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                txtClave.Text = string.Empty;



            }
        }
            catch (Exception)
            {


            }
		}
	}
}
