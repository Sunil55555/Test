using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleAppGit
{
    [TestFixture]
    class ProgramTest
    {
        [Test]
        public void test()
        {
            Program p = new Program();
            Assert.AreEqual(57, p.calculate());
        }
    }
}
