using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class UnitTest4
    { 
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
                Assert.IsNotNull(AnStaff);
        }
    }
}