using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Pet_And_Me__;

namespace PlayerPetUnitTest
{
    [TestClass]
    public class DogUnitTest
    {
        [TestMethod]
        public void CheckDogProperties() => PetUnitTestMethods.CheckPetDefaultValues(new Dog(PetUnitTestMethods.jeanpaulPlayer));
    }
}
