using AFNDConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutomataTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para TransitionTest y se pretende que
    ///contenga todas las pruebas unitarias TransitionTest.
    ///</summary>
    [TestClass()]
    public class TransitionTest
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
        ///Una prueba de Constructor Transition
        ///</summary>
        [TestMethod()]
        public void TransitionConstructorTest()
        {
            string from = "q0"; // TODO: Inicializar en un valor adecuado
            string with = "b"; // TODO: Inicializar en un valor adecuado
            string[] to = {"q1"}; // TODO: Inicializar en un valor adecuado
            Transition target = new Transition(from, with, to);
            Assert.IsInstanceOfType(target, typeof(Transition),"No es tipo transition");
            Assert.IsInstanceOfType(target.from, typeof(string), "No es un string");
            Assert.IsInstanceOfType(target.with, typeof(string), "No es tipo string");
            Assert.IsInstanceOfType(target.to, typeof(string[]), "No es tipo string[]");

            Console.WriteLine("Estado {0} transiciona con {1} al estado {2}",target.from, target.with, target.to[0]);

        }
    }
}
