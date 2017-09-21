using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.ServiceReference1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static string apikey;

        public UnitTest1()
        {
            var apikeys = new ApiKeyServiceClient();
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
