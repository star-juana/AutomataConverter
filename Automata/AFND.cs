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
        public string[] _alphabet;
        public string[] _states;
        public string _initialState;
        public string[] _finalsStates;
        public List<Transition> _transitions;
        #endregion

        #region Constructor

        public AFND(string[] alphabet, string[] states, string initialState, string[] finalsStates, List<Transition> transitions) 
        {
            this._alphabet = alphabet;
            this._states = states;
            this._initialState = initialState;
            this._finalsStates = finalsStates;
            this._transitions = transitions;
        }
        #endregion

        #region Metodos auxiliares


        #endregion
    }
}
