using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Montreal
{
    class Programa
    {
        private string _programa_id;
        private string _nombre;
        private string _descripcion;
        private string _pais_destino;
        private string _fecha_inicio;
        private string _fecha_termino;
        private int _cupos;
        private char _programa_asignado;

        public string Programa_id
        {
            get
            {
                return _programa_id;
            }

            set
            {
                _programa_id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        public string Pais_destino
        {
            get
            {
                return _pais_destino;
            }

            set
            {
                _pais_destino = value;
            }
        }

        public string Fecha_inicio
        {
            get
            {
                return _fecha_inicio;
            }

            set
            {
                _fecha_inicio = value;
            }
        }

        public string Fecha_termino
        {
            get
            {
                return _fecha_termino;
            }

            set
            {
                _fecha_termino = value;
            }
        }

        public int Cupos
        {
            get
            {
                return _cupos;
            }

            set
            {
                _cupos = value;
            }
        }

        public char Programa_asignado
        {
            get
            {
                return _programa_asignado;
            }

            set
            {
                _programa_asignado = value;
            }
        }

        public Programa(string _programa_id, string _nombre, string _descripcion, string _pais_destino, string _fecha_inicio, string _fecha_termino, int _cupos, char _programa_asignado)
        {
            this._programa_id = _programa_id;
            this._nombre = _nombre;
            this._descripcion = _descripcion;
            this._pais_destino = _pais_destino;
            this._fecha_inicio = _fecha_inicio;
            this._fecha_termino = _fecha_termino;
            this._cupos = _cupos;
            this._programa_asignado = _programa_asignado;
        }
    }
}
