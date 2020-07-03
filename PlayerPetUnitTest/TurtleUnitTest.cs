using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Pet_And_Me__;

namespace PlayerPetUnitTest
{
    [TestClass]
    public class TurtleUnitTest
    {
        [TestMethod]
        public void CheckTurtleProperties() => PetUnitTestMethods.CheckPetDefaultValues(new Turtle(PetUnitTestMethods.jeanpaulPlayer));
    }
}
