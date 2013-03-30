using AFNDConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AutomataTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para AFNDTest y se pretende que
    ///contenga todas las pruebas unitarias AFNDTest.
    ///</summary>
    [TestClass()]
    public class AFNDTest
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
        ///Una prueba de Constructor AFND
        ///</summary>
        [TestMethod()]
        public void AFNDConstructorTest()
        {
            string[] alphabet = {"a","b"}; // TODO: Inicializar en un valor adecuado
            string[] states = {"q0","q1","q1","q3"}; // TODO: Inicializar en un valor adecuado
            string initialState = {"q1"}; // TODO: Inicializar en un valor adecuado
            string[] finalsStates = null; // TODO: Inicializar en un valor adecuado
            Transition q0b = new Transition("q0","b", new string[] {"q1","q2"});
            Transition q0a = new Transition("q0", "a", new string[] { "q0", "q1" });
            List<Transition> transitions = new List<Transition> {q0a, q0b };
            AFND target = new AFND(alphabet, states, initialState, finalsStates, transitions);
            
        }
    }
}
