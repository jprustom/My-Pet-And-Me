using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Pet_And_Me__;

namespace PlayerPetUnitTest
{
    [TestClass]
    public class CatUnitTest
    {
        [TestMethod]
        public void CheckCatProperties() => PetUnitTestMethods.CheckPetDefaultValues(new Cat(PetUnitTestMethods.jeanpaulPlayer));
    }
}
