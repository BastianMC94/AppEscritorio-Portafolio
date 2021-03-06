﻿using MetroFramework.Forms;
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
using System.Net.Http.Formatting;
using APP;
using System.Net;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;


namespace GUI
{
	public partial class listaCEM : MetroForm
	{
		public listaCEM()
		{
			InitializeComponent();
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://portafoliapi.herokuapp.com/rest/");
            HttpResponseMessage response = client.GetAsync("encargadoCEM/listarTodos").Result;
            var listacem = response.Content.ReadAsAsync<IEnumerable<listarCEM>>().Result;

           

            metroGridMovimientos.DataSource = listacem;
           //metroGridMovimientos.DataBindings();


        }

	
    }
}
