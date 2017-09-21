using System;
using MaddalenaUnitTest.MaddalenaServiceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaddalenaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        static string apikey;

        public UnitTest1()
        {
            var apikeys = new ApiKeyServiceClient("BasicHttpBinding_IApiKeyService");
            apikey = apikeys.Create("q@q.q");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var users = new UserServiceClient();
            var u = users.ByEmail("q@q.q");
            Assert.AreNotEqual(u, null);
        }
    }
}
