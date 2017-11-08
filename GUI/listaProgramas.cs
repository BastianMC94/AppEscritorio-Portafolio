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
using System.Net.Http.Formatting;
using APP;
using System.Net;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;


namespace GUI
{
	public partial class listaProgramas : MetroForm
	{
		public listaProgramas()
		{
			InitializeComponent();
            //LlenarGrilla();
		}

        //private void LlenarGrilla()
        //{
        //    //Programar Lista
        //    WebRequest request = WebRequest.Create("https://portafoliapi.herokuapp.com/rest/programa/listarTodos");

        //    using (var response = request.GetResponse() as HttpWebResponse)
        //    {
        //        Stream responseStream = response.GetResponseStream();
        //        using (var reader = new StreamReader(responseStream))
        //        {
        //            // get the response as text
        //            string responseText = reader.ReadToEnd();
        //            var settings = new JsonSerializerSettings
        //            {
        //                ObjectCreationHandling = ObjectCreationHandling.Replace,

        //            };

        //            // convert from text 
        //            List<string> results = JsonConvert.DeserializeObject<List<string>>(responseText, settings);
                

        //            metroGridMovimientos.DataSource = responseText;
        //            //metroGridMovimientos.DataBindings();
                    


        //        }
        //    }

        //}

        //    public async static Task<listarPrograma>GetPrograma(string programa_id, string nombre_programa, string pais_destino, string fecha_inicio, string fecha_termino, int cupos)
        //    {
        //        var http = new HttpClient();
        //        var url = string.Format("https://portafoliapi.herokuapp.com/rest/programa/listarTodos", programa_id, nombre_programa, pais_destino, fecha_inicio, fecha_termino, cupos);
        //        var response = await http.GetAsync(url);
        //        var result = await response.Content.ReadAsStringAsync();
        //        var serializer = new DataContractJsonSerializer(typeof(listarPrograma));

        //        var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
        //        var data = (listarPrograma)serializer.ReadObject(ms);

        //    }
    }
}
