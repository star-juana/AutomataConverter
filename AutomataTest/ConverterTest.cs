using AFNDConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AutomataTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para ConverterTest y se pretende que
    ///contenga todas las pruebas unitarias ConverterTest.
    ///</summary>
    [TestClass()]
    public class ConverterTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de Constructor Converter
        ///</summary>
        [TestMethod()]
        public void ConverterConstructorTest()
        {
            List<string> alphabet = new List<string> { "a", "b" };
            List<string> states = new List<string> { "q0", "q1", "q1", "q3" };
            List<string> initialState = new List<string> { "q1" };
            List<string> finalsStates = null;
            Transition q0b = new Transition("q0", "b", "q1");
            Transition q0a = new Transition("q0", "a", "q2");
            List<Transition> transitions = new List<Transition> { q0a, q0b };
            AFND afnd = new AFND(alphabet, states, initialState, finalsStates, transitions);
            Converter target = new Converter(afnd);
        }



        /// <summary>
        ///Una prueba de cerraduraEpsilon
        ///</summary>
        [TestMethod()]
        public void cerraduraEpsilonTest()
        {
            Transition t1 = new Transition("q0", "epsilon", "q1");
            Transition t2 = new Transition("q0", "epsilon", "q2");
            Transition t3 = new Transition("q1", "epsilon", "q3");
            Transition t4 = new Transition("q1", "a", "q4");
            List<Transition> transiciones = new List<Transition> { t1, t2, t3, t4 };
            List<string> estadosIniciales = new List<string> {"q0"}; // TODO: Inicializar en un valor adecuado
            int indiceConjunto = 0; // TODO: Inicializar en un valor adecuado
            List<string> expected = new List<string> { "q1", "q2", "q3", "q4" }; // TODO: Inicializar en un valor adecuado
            List<string> actual;
            actual = Converter.cerraduraEpsilon(transiciones, estadosIniciales, indiceConjunto);
            foreach (string a in actual)
            {
                Console.WriteLine("en epsilon luego de ejecutado todo {0}", a);
            }
            //Assert.AreEqual(expected, actual);
        }
    }
}
