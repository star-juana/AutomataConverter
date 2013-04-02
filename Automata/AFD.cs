using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFNDConverter
{
    class AFD
    {

        //Esta clase permite definir unchecked AFND y tenerlo por separado del resto de componentes del programa
        #region Atributos
        public List<string> _alfabeto;
        public List<string> _estados;
        public List<string> _estadoInicial;
        public List<string> _estadosFinales;
        public List<Transition> _trancisiones;
        #endregion

        #region Constructor

        public AFD(List<string> alfabeto, List<string> estadoInicial) 
        {
            this._alfabeto = alfabeto;
            this._estadoInicial = estadoInicial;
        }
        #endregion

        #region Metodos auxiliares

        public List<string> EstadoInicial
        {
            get { return _estadoInicial; }
            set { _estadoInicial = value; }
        }

        public List<string> EstadosFinales
        {
            get { return _estadosFinales; }
            set { _estadosFinales = value; }
        }

        public List<string> Alfabeto
        {
            get { return _alfabeto; }
            set { _alfabeto = value; }
        }

        public List<string> Estados
        {
            get { return _estados; }
            set { _estados = value; }
        }

        public List<Transition> Trancisiones
        {
            get { return _trancisiones; }
            set { _trancisiones = value; }
        }

        #endregion

    }
}
