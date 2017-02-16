using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Tests
{
    [TestClass()]
    public class HelloWorldTests
    {
        [TestMethod()]
        public void No_name()
        {
            Assert.AreEqual(HelloWorld.Hello(null), "Hello, World!");
        }

        [TestMethod()]
        public void Sample_name()
        {
            Assert.AreEqual(HelloWorld.Hello("Alice"),"Hello, Alice!");
        }

        [TestMethod()]
        public void Other_sample_name()
        {
            Assert.AreEqual(HelloWorld.Hello("Bob"), "Hello, Bob!");
        }
    }
}