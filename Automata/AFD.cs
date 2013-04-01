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

        public AFD(List<string> alfabeto, string estadoInicial) 
        {
            this._alfabeto = alfabeto;
            this._estadoInicial.Add(estadoInicial);
        }
        #endregion

        #region Metodos auxiliares
        #endregion

    }
}
