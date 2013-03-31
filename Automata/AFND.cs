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
        List<string> _alphabet = new List<string>();
        List<string> _states = new List<string>();
        List<string> _initialState = new List<string>();
        List<string> _finalsStates = new List<string>();
        List<Transition> _transitions = new List<Transition>();
        #endregion

        #region Constructor

        public AFND(List<string> alphabet, List<string> states, List<string> initialState, List<string> finalsStates, List<Transition> transitions) 
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
