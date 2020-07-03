using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Pet_And_Me__;

namespace PlayerPetUnitTest
{
    [TestClass]
    public class FoxUnitTest
    {
        [TestMethod]
        public void CheckFoxProperties() => PetUnitTestMethods.CheckPetDefaultValues(new Fox(PetUnitTestMethods.jeanpaulPlayer));
    }
}
