using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Pet_And_Me__;

namespace PlayerPetUnitTest
{
    [TestClass]
    public class RabbitUnitTest
    {
        [TestMethod]
        public void CheckRabbitProperties() => PetUnitTestMethods.CheckPetDefaultValues(new Rabbit(PetUnitTestMethods.jeanpaulPlayer));
    }
}
