using MetroFramework.Forms;
using MetroFramework;
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

namespace GUI
{
	public partial class Login : MetroForm
	{
		public Login()
		{
			InitializeComponent();
			txtCorreo.Select();
		}


		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
            if (txtCorreo.Text == "admin" && txtContrasena.Text == "admin")
            {
                GUI.Menu winMenu = new GUI.Menu();
                			winMenu.ShowDialog();
                            	this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Usuario o contraseña invalidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //	try
            //	{
            //		if (txtCorreo.Text.Equals(""))
            //		{
            //			MetroMessageBox.Show(this, "Correo Vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //			return;
            //		}
            //		if (txtContrasena.Text.Equals(""))
            //		{
            //			MetroMessageBox.Show(this, "Escriba una contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //			return;
            //		}
            //		Usuario usuario = new Usuario();
            //		usuario.Correo = txtCorreo.Text.Trim();
            //		usuario.Clave = txtContrasena.Text.Trim();


            //		string webAddr = "https://portafoliapi.herokuapp.com/rest/encargadoCEM/login";

            //		var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            //		httpWebRequest.ContentType = "application/json; charset=utf-8";
            //		httpWebRequest.Method = "POST";

            //		using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //		{
            //			//string json = "{ \"correo\" : \"cem@gmail.com\", \"clave\" : \"cemclave\" }";
            //			string json = "{ \"correo\" : \"" + usuario.Correo 
            //                      + "\", \"clave\" : \"" + usuario.Clave + "\"}";
            //			streamWriter.Write(json);
            //			streamWriter.Flush();
            //		}
            //		var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //		using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //		{
            //			var responseText = streamReader.ReadToEnd();
            //			if (responseText == "true")
            //			{
            //				GUI.Menu winMenu = new GUI.Menu();
            //				winMenu.ShowDialog();
            //				this.Close();
            //			}
            //			else
            //			{
            //				MetroMessageBox.Show(this, "Datos Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //			}
            //			MetroMessageBox.Show(this, responseText, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //			//Now you have your response.
            //			//or false depending on information in the response     
            //		}
            //	}
            //	catch (WebException ex)
            //	{
            //		//MetroMessageBox.Show(this, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //	}
        }

       
    }
}


