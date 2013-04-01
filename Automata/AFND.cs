using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFNDConverter
{
    //Esta clase permite definir unchecked AFND y tenerlo por separado del resto de componentes del programa
    class AFND
    {
        #region Atributos
        List<string> _alfabeto;
        List<string> _estados;
        string _estadoInicial; //Es una solo estado no es necesario que sea un lista
        List<string> _estadosFinales;
        List<Transition> _transiciones;
        #endregion

        #region Constructor

        public AFND(List<string> alphabet, List<string> states, string initialState, List<string> finalsStates, List<Transition> transitions) 
        {
            this._alfabeto = alphabet;
            this._estados = states;
            this._estadoInicial = initialState;
            this._estadosFinales = finalsStates;
            this._transiciones = transitions;
        }
        #endregion

        #region Metodos auxiliares

        void AgregarUnaTransicion(Transition transicion)
       {
           this._transiciones.Add(transicion);

       }

        #endregion
    }
}
