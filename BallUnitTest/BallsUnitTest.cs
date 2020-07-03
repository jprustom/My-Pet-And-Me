using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Pet_And_Me__;

namespace BallUnitTest
{
    [TestClass]
    public class BallsUnitTest
    {
        static Dog dog = (new Dog(new Player("JP", 3)));
        PongGameForm pongForm = new PongGameForm(dog);
        BrickBreakerGameForm brickBreakerForm = new BrickBreakerGameForm(dog);

        [TestMethod]
        public void IsListOfBallsEmptyTestBrickBreaker()
        {
            BallGame myBallGame = new BallGame(new BrickBreakerGameMode(brickBreakerForm));
            Assert.AreEqual(myBallGame.Balls.Count, 0);
        }
        public void IsListOfBallsEmptyTestPong()
        {

            BallGame myBallGame = new BallGame(new PongGameMode(pongForm));
            Assert.AreEqual(myBallGame.Balls.Count, 0);
        }
        public void DoesBallHavePongFaçade()
        {
            Ball myBall = new Ball(pongForm);
            Assert.IsNotNull(myBall.ManageBallFaçade);
        }
        public void DoesBallHaveBrickBreakerFaçade()
        {
            Ball myBall = new Ball(pongForm);
            Assert.IsNotNull(myBall.ManageBallFaçade);
        }
    }
}
