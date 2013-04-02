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
        public Dictionary<int, List<string>> _conjutosEstados;

        #region Constructor
        public Converter(AFND afnd)
            {
                //Coloco el AFND en su sitio
                
                
                // 1 - Asigno el estado inicial del AFND al AFD
                this._AFND = new AFND(afnd._alfabeto,afnd._estados,afnd._estadoInicial,afnd._estadosFinales, afnd._transiciones);
                
                // 2 - Asigno la cerradura epsilon del estado inicial al conjunto de estados
                this._AFD = new AFD(this._AFND._alfabeto, this._AFND._estadoInicial);
                
                cerraduraEpsilon(_AFND._transiciones, _AFD._estadoInicial);
                
                // 3 - Itero en busca de las transiciones con cada elemento del alfabeto en busca de los estado en que terminan
                // 4 - Las transiciones que coinciden en la busqueda de 3 las agrego a la lista de conjuntos
                // 5 - Aplico la cerradura epsilon al ultimo elemto de la lista de conjuntos
                // 6 - Verifico si el ultimo conjunto es igual a alguno de los anteriores
                // 6.1 - Si NO existe agrego el ultimo conjunto creado a la lista de conjuntos
                // 6.2 - Si existe solo agrego el indice del conjunto ya existente a la lista de conjuntos
                // 7 - Luego de iterar los elemntos del alfabeto, creo las transiciones tomando como nombre del estado el indice del conjunto en la lista
                // 8 - Repito de de 3 a 7 hasta no hallar conjuntos nuevos
                // 9 - Busco los estados finales dentro de la lista de conjuntos
                // 10 - Agrego los estados finales al AFD

            }
        #endregion

        #region Metodos principales

        //Metodo para agregar elementos a al conjunto de nuevos estados

        //Metodo para la cerradura epsilon
        public static string cerraduraEpsilon(List<Transition> transiciones, List<string> estadosIniciales, int indiceConjunto) 
        {
            //creo la lista que albergará los estados que transicionas con epsilon
            List<string> conjunto_epsilon = new List<string>(); 

            //Recorro cada una de las transiciones indicadas para buscar quienes transicionan con epsilon
            foreach (Transition transicion in transiciones)
            {
                foreach (string estadoInicial in estadosIniciales)
                {
                    //Verifico que el estado inicial de la transicion en curso sea igual al estado inicial que se selecciona
                    if (transicion._inicia == estadoInicial)
                    {
                        //Verifico que ese estado inicial transiciona con "epsilon"
                        if (transicion._con == "epsilon")
                        {
                            //Agrego el estado en que termina la transicion a la lista que estados finales con
                            //transicion epsilon que ingresan a la cerradura
                            return transicion._terminaEn;
                            cerraduraEpsilon(transiciones, conjunto_epsilon); //"Recursividad"
                        }
                    }
                }

            }
            
            return conjunto_epsilon;
            this._conjutosEstados.Add(conjunto_epsilon);
        }

        //Metodo para verificar si existe o no un conjunto entrante respecto a los que están
        public static bool ExisteElConjunto(string[] conjuntoEntrante, List<string[]> ListaConjuntosExistentes){
            bool respuesta = false;

            foreach (string[] conjuntoExistente in ListaConjuntosExistentes)
            {
                if (conjuntoExistente.Length == conjuntoEntrante.Length)
                {
                    respuesta = false;
                }
                else 
                {
                    int c = 0;
                    foreach (string elementoExistente in conjuntoExistente)
                    {
                        foreach (string elementoEntrante in conjuntoEntrante)
                        {
                            if (elementoExistente == elementoEntrante)
                            {
                                c++;
                            }
                        }
                    }

                    if ((conjuntoExistente.Length == c) || (conjuntoEntrante.Length == c))
                    {
                        respuesta = true;
                    }
                    else
                    {
                        respuesta =  false;
                    }
                }
            }
            return respuesta;
        }

        //Toma las transiciones en cuyos estados, se inicie con lo pedido estados que ingresen con el simbolo del alfabeto señalado
        static List<Transition> obtenerTransiciones(string[] estadosIniciales, string transicionaCon, List<Transition> trancisiones) 
        {
            //Lista donde SerializableAttribute almacenan los estados que coinciden const las condiciones
            List<Transition> estados = new List<Transition>();

            //Bucle para buscar las coincidencias
            foreach (string estadoInicial in estadosIniciales)
            {
                foreach (Transition estado in trancisiones)
                {
                    if (estado.inicia == estadoInicial)
                        if (estado.con == transicionaCon)
                            estados.Add(estado);
                }
            }

            return estados;
        }

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
