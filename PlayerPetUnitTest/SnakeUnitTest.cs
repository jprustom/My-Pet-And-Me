using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Pet_And_Me__;

namespace PlayerPetUnitTest
{
    [TestClass]
    public class SnakeUnitTest
    {
        [TestMethod]
        public void CheckSnakeProperties() => PetUnitTestMethods.CheckPetDefaultValues(new Snake(PetUnitTestMethods.jeanpaulPlayer));
    }
}
