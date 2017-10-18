using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace Solucion_Montreal
{
    public class Usuario
    {

        public string _correo;
        public string _clave;

        public Usuario(string _correo, string _clave)
        {
            this._correo = _correo;
            this._clave = _clave;
        }

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
    }
}
