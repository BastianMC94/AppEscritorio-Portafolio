using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class EncargadoCEL
    {
        private string cel_id;
        private string institucion;
        private string correo;
        private string pais;
        private string clave;

        public EncargadoCEL() { }
        public string Cel_id
        {
            get
            {
                return cel_id;
            }

            set
            {
                cel_id = value;
            }
        }

        public string Institucion
        {
            get
            {
                return institucion;
            }

            set
            {
                institucion = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public EncargadoCEL(string cel_id, string institucion, string correo, string pais, string clave)
        {
            this.Cel_id = cel_id;
            this.Institucion = institucion;
            this.Correo = correo;
            this.Pais = pais;
            this.Clave = clave;
        }
    }
}
