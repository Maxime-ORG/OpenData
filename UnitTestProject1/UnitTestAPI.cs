using LibraryAPI2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAPI
    {
        [TestMethod]
        public void TestMethod1()
        {
            IAPIRequest request = new FakeAPIRequest();
            APIdeserialize aPIdeserialize = new APIdeserialize(request);
            List<LibraryAPI2.LineNear> test = aPIdeserialize.GetLines();
            Assert.AreEqual("test", test[0].id);
            Assert.AreEqual("test", test[0].name);
            Assert.AreEqual("test", test[0].lines[0]);
        }
    }
}
