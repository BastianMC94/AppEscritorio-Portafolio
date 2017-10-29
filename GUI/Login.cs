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

namespace GUI
{
	public partial class Login : MetroForm
	{
		public Login()
		{
			InitializeComponent();
            txtCorreo.Select();
		}

		private void Login_Load(object sender, EventArgs e)
		{
           
		}

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

			#region
			//Validaciones
			int count = 0;

                if (txtCorreo.Text.Equals("") & txtContrasena.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Debe ingresar sus credenciales", "Advertencia",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (txtCorreo.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Ingrese su correo electrónico", "Advertencia",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (txtContrasena.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Ingrese su contraseña", "Advertencia",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
            #endregion //Validaciones
            //Autentificar correo y clave, probar
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var byteArray = Encoding.ASCII.GetBytes("correo:clave");

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            HttpResponseMessage response = client.GetAsync("http://portafoliapi.herokuapp.com/rest/encargadoCem/login").Result;
        }

        }
    }

