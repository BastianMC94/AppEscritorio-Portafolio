using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class EncargadoCEM
    {
        private string cem_id;
        private string sede;
        private string correo;
        private string clave;

        public EncargadoCEM() { }
        public string Cem_id
        {
            get
            {
                return cem_id;
            }

            set
            {
                cem_id = value;
            }
        }

        public string Sede
        {
            get
            {
                return sede;
            }

            set
            {
                sede = value;
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

        public EncargadoCEM(string _cem_id, string _sede, string _correo, string _clave)
        {
            this.Cem_id = _cem_id;
            this.Sede = _sede;
            this.Correo = _correo;
            this.Clave = _clave;
        }
    }
}
