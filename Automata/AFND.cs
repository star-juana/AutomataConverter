using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFNDConverter
{
    //Esta clase permite definir unchecked AFND y tenerlo por separado del resto de componentes del programa
    public class AFND
    {
        #region Atributos
        public List<string> _alfabeto;
        public List<string> _estados;
        public List<string> _estadoInicial;
        public List<string> _estadosFinales;
        public List<Transition> _transiciones;
        #endregion

        #region Constructor

        public AFND(List<string> alphabet, List<string> states, List<string> initialState, List<string> finalsStates, List<Transition> transitions) 
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

        internal void cerraduraEpsilon(List<Transition> transiciones, List<string> list, int indiceConjunto)
        {
            throw new NotImplementedException();
        }
    }
}
