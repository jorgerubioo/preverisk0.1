using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Presentation;
using domains;
using Domain;
using Common1.Cache;
using System.Runtime.Remoting.Messaging;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestmostrarAccident()
        {
            //Data gridview no es nulo (tiene datos)
            CN_Accidentabilidad objeto = new CN_Accidentabilidad();

            Assert.IsNotNull(objeto);

        }

        [TestMethod]
        public void TestDivision()
        {
            //Definimos las variables
            //Arrange
            var txtNtrabajadores = 10;
            var txtNaccidentes = 2;

            //Ejecutamos la prueba
            //Act
            var txtResultadodiv = (txtNtrabajadores / txtNaccidentes);

            //Comparamos resultados
            //Assert
            var valorEsperado = 5;
            Assert.AreEqual(valorEsperado, txtResultadodiv);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))] //Excepcion esperada
        public void TestDivisionExcepcion()
        {
            //Definimos las variables
            //Arrange
            var txtNtrabajadores = 10;
            var txtNaccidente = 0;

            //Ejecutamos la prueba
            //Act
             var txtResultadodiv = (txtNtrabajadores / txtNaccidente);

            //Comparamos resultados
            //Assert
            //En este caso, no deberiamos llegar aqui, la prueba correcta es una excepción de DivisionEntreCero
        }

        [TestMethod]
        public void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            Assert.IsNotNull(objeto);
        }
    }
}
       
