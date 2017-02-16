using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap.Tests
{
    [TestClass()]
    public class LeapTests
    {

        [TestMethod()]
        public void Valid_leap_year()
        {
            Assert.IsTrue(Leap.IsLeap(1996));
        }

        [TestMethod()]
        public void Invalid_leap_year()
        {
            Assert.IsFalse(Leap.IsLeap(1997));
        }
        [TestMethod()]
        public void Turn_of_the_20th_century_is_not_a_leap_year()
        {
            Assert.IsFalse(Leap.IsLeap(1900));
        }

        [TestMethod()]
        public void Turn_of_the_25th_century_is_a_leap_year()
        {
            Assert.IsTrue(Leap.IsLeap(2400));
        }
    }
}