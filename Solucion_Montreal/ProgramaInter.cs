using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace APP
{
   public class ProgramaInter
    {
        public string _programa_id;
        public string _nombre_programa;
        public string _descripcion;
        public string _pais_destino;
        public string _fecha_inicio;
        public string _fecha_termino;
        public int _cupos;
        public char _programa_asignado;
        public string _cel_id;
        public string _cem_id;

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

        public string Nombre_programa
        {
            get
            {
                return _nombre_programa;
            }

            set
            {
                _nombre_programa = value;
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

        public string Cel_id
        {
            get
            {
                return _cel_id;
            }

            set
            {
                _cel_id = value;
            }
        }

        public string Cem_id
        {
            get
            {
                return _cem_id;
            }

            set
            {
                _cem_id = value;
            }
        }

        public ProgramaInter(string _programa_id, string _nombre_programa, string _descripcion, string _pais_destino, string _fecha_inicio, string _fecha_termino, int _cupos, char _programa_asignado, string _cel_id, string _cem_id)
        {
            this._programa_id = _programa_id;
            this._nombre_programa = _nombre_programa;
            this._descripcion = _descripcion;
            this._pais_destino = _pais_destino;
            this._fecha_inicio = _fecha_inicio;
            this._fecha_termino = _fecha_termino;
            this._cupos = _cupos;
            this._programa_asignado = _programa_asignado;
            this._cel_id = _cel_id;
            this._cem_id = _cem_id;
        }

        public ProgramaInter()
        {
        }

        
    }
}
