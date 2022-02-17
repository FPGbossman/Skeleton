using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        { 
            clsStock AStock = new clsStock(); 

        Assert.IsNotNull(AStock); 

        }
    }
}
