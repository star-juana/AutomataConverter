using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AFNDConverter
{
    public class Converter
    {
        //Atributo de la clase que contendrá el AFND a convertir
        //TODO: Discutir sobre el uso de propiedades o atributos
        public AFND _AFND;
        public AFD _AFD;
        public Dictionary<int, List<string>> _conjutosEstados;
        public static List<List<string>> ListaConjuntosExistentes = new List<List<string>>();
        #region Constructor
        public Converter(AFND afnd)
        {
            //Coloco el AFND en su sitio


            // 1 - Asigno el estado inicial del AFND al AFD
            this._AFND = new AFND(afnd._alfabeto, afnd._estados, afnd._estadoInicial, afnd._estadosFinales, afnd._transiciones);

            // 2 - Asigno la cerradura epsilon del estado inicial al conjunto de estados
            this._AFD = new AFD(this._AFND._alfabeto, this._AFND._estadoInicial);

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
        void AgregaraConjuntoDeEstados(string estado, int indiceEstado)
        {
            if (this._conjutosEstados[indiceEstado] == null)
            {
                this._conjutosEstados.Add(indiceEstado, new List<string> { estado });
            }
            else
            {
                this._conjutosEstados[indiceEstado] = new List<string> { estado };
            }
        }

        //Metodo para la cerradura epsilon
        public static List<string> cerraduraEpsilon(List<Transition> transiciones, List<string> estadosIniciales, int indiceConjunto)
        {
            //creo la lista que albergará los estados que transicionas con epsilon
            List<string> conjunto_epsilon = new List<string>();

            //Recorro cada una de las transiciones indicadas para buscar quienes transicionan con epsilon
            foreach (Transition transicion in transiciones)
            {
                foreach (string elemento in estadosIniciales)
                {
                    //Verifico que el estado inicial de la transicion en curso sea igual al estado inicial que se selecciona
                    if ((transicion._inicia == elemento) && (transicion._con == "epsilon") && !(conjunto_epsilon.Contains(transicion._terminaEn)))
                    {
                        //Verifico que ese estado inicial transiciona con "epsilon"
                        string temp = transicion._terminaEn;
                        conjunto_epsilon.Add(transicion._terminaEn);


                        if (ExisteElConjunto(conjunto_epsilon, ListaConjuntosExistentes) == true)
                        {
                           ListaConjuntosExistentes.Add(conjunto_epsilon);
                        }
                        else
                        {
                            cerraduraEpsilon(transiciones, conjunto_epsilon, indiceConjunto); //"Recursividad"
                        }
                    } 
                    //else if(transicion._inicia == transicion._terminaEn) && 
                    //{
                    //    conjunto_epsilon.Add(transicion._terminaEn);
                    //}

                }

            }


            foreach (string elemento in conjunto_epsilon)
            {
                Console.WriteLine("En conjuntoEpsilon antes de enviar {0}", elemento);
            }
            return conjunto_epsilon;

        }

        //Metodo para verificar si existe o no un conjunto entrante respecto a los que están
        public static bool ExisteElConjunto(List<string> conjuntoEntrante, List<List<string>> Lista)
        {
            bool respuesta = false;

            foreach (List<string> conjuntoExistente in ListaConjuntosExistentes)
            {


                if (conjuntoExistente.Count - 1 == conjuntoEntrante.Count - 1)
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

                        if ((conjuntoExistente.Count - 1 == c) || (conjuntoEntrante.Count - 1 == c))
                        {
                            respuesta = true;
                        }
                        else
                        {
                            respuesta = false;
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
                    if (estado._inicia == estadoInicial)
                        if (estado._con == transicionaCon)
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

        #endregion

    }
}
