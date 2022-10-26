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
        public void mostrarAccident()
        {
            CN_Accidentabilidad objeto = new CN_Accidentabilidad();

            Assert.IsNotNull(objeto);

        }

        
        
    }
}
