using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AFNDConverter
{
    class Converter
    {
        //Atributo de la clase que contendrá el AFND a convertir
        //TODO: Discutir sobre el uso de propiedades o atributos
        public AFND _AFND;
        public AFD _AFD;

        #region Constructor
        public Converter(AFND afnd)
            {
                this._AFND = afnd;
            }
        #endregion

        #region Metodos principales

        static string[] EpsilonLock() 
        {
            return new string[] { "a" };
        }

        //Toma las transiciones en cuyos estados, se inicie con lo pedido estados que ingresen con el simbolo del alfabeto señalado
        static List<Transition> getTransitions(string[] initialStates, string transitionWith, List<Transition> transitions) 
        {
            //Lista donde SerializableAttribute almacenan los estados que coinciden const las condiciones
            List<Transition> states = new List<Transition>();

            //Bucle para buscar las coincidencias
            foreach (string initialestate in initialStates)
            {
                foreach (Transition state in transitions)
                {
                    if (state.from == initialestate)
                        if (state.with == transitionWith)
                            states.Add(state);
                }
            }

            return states;
        }

        //static AFD toAFD() {

        //    return new AFD();
        //}
        #endregion

        #region Metodos auxiliares

        //Metodo que toma una cadena separda por comas (',') y devuelve un array con los elementos de la cadena
        //Este método debe ir en el formulario para colocarlo donde va
        public static string[] stringToArray(string input)
        {
            string[] separators = { ",", " ,", ", " };
            return input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string[] cerraduraEpsilon(List<Transition> transitions) 
        {
            return new string[] {"a"};
        }

        #endregion
    }
}
