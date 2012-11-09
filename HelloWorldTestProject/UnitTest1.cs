using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassLibrary1.Class1 klass = new ClassLibrary1.Class1();
            string helloWorld = klass.GetHelloWorld();
            Assert.AreEqual("Hello world", helloWorld);
        }

        [TestMethod]
        public void TestMethod1()
        {
            ClassLibrary1.Class1 klass = new ClassLibrary1.Class1();
            string helloWorld = klass.GetHelloWorld("richard");
            Assert.AreEqual("Hello world", helloWorld);
        }
    }
}
