using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFNDConverter
{
    class AFD
    {
        //si se ve esto es una prueba correcta
          //Esta clase permite definir unchecked AFND y tenerlo por separado del resto de componentes del programa
        #region Atributos
        public string[] _alphabet;
        public string[] _states;
        public string[] _initialState;
        public string[] _finalsStates;
        public List<Transition> _transitions;
        #endregion

        #region Constructor

        public AFD(string alphabet, string states, string initialState, string finalsStates, List<Transition> transitions) 
        {
            this._alphabet = stringToArray(alphabet);
            this._states = stringToArray(states);
            this._initialState = stringToArray(initialState);
            this._finalsStates = stringToArray(finalsStates);
            this._transitions = transitions;
        }
        #endregion

        #region Metodos auxiliares

        //Metodo que toma una cadena separda por comas (',') y devuelve un array con los elementos de la cadena
        public static string[] stringToArray(string input)
        {
            string[] separators = { ",", " ,", ", " };
            return input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        #endregion
    }
}
