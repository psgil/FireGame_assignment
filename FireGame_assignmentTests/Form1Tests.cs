using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame_assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_assignment.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 form = new Form1();
            form.chance(1, 1);
            Assert.IsTrue(true);
        }
    }
}