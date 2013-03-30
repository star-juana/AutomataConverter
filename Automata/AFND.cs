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
        public string[] _initialState;
        public string[] _finalsStates;
        public List<Transition> _transitions;
        #endregion

        #region Constructor

        public AFND(string alphabet, string states, string initialState, string finalsStates, List<Transition> transitions) 
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
            return input.Split(new Char[] { ',' });
        }

        public static void lectura()
        {
           Console.WriteLine("Introduzca alfabeto separados por ","");
            String alfabeto;
            alfabeto = Console.ReadLine();
            
        }
        public static void transitions()
        {
            

        }


        #endregion
    }
}
