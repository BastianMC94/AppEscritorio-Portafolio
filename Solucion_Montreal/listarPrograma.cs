using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
   public  class listarPrograma
    {
        public string programa_id { get; set; }
        public string nombre_programa { get; set; }
        public string descripcion { get; set; }
        public string pais_destino { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_termino { get; set; }
        public int cupos { get; set; }
        public int programa_asignado { get; set; }
        public string cel_id { get; set; }
        public string cem_id { get; set; }
    }
}
