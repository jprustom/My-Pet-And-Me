using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Pet_And_Me__;

namespace PlayerPetUnitTest
{
    
    public static class PetUnitTestMethods
    {

        public static Player jeanpaulPlayer = new Player("Jean-Paul", 20);

        public static void CheckPetDefaultValues(Pet pet)
        {
            Assert.IsNotNull(pet.AssociatedPlayer);
            Assert.IsNotNull(pet.PetFullImage);
            Assert.IsNotNull(pet.PetName);
            CheckSnakeValues(pet);
            CheckPetBrickBreakerPaddleValues(pet);
        }
        private static void CheckSnakeValues(IPetSnake IPetSnake)
        {
            Assert.AreEqual(IPetSnake.SnakeDirection, SnakeGameMode.SnakeDirection.Up);
            Assert.IsNotNull(IPetSnake.PetSnakeBodyPartImage);
            Assert.IsNotNull(IPetSnake.PetSnakeHeadImage);
            Assert.IsNotNull(IPetSnake.PetSnakeCollectiblesList);
        }


       private static void CheckPetBrickBreakerPaddleValues(IPetBrickBreakerPaddle IPetBrickBreakerPaddle)
        {
            Assert.AreEqual(IPetBrickBreakerPaddle.PetBrickBreakerPaddleDirection, BrickBreakerGameMode.PetBrickBreakerPaddleDirection.Idle);
            Assert.IsNotNull(IPetBrickBreakerPaddle.PetBrickBreakerPaddlePictureBox);
            Assert.AreEqual(IPetBrickBreakerPaddle.PetPaddleBrickBreakerSpeed, BrickBreakerGameMode.BrickBreakerBallSpeed);
        }

        private static void CheckPetPongPaddleValues(IPetPongPaddle IPetPongPaddle)
        {
            Assert.AreEqual(IPetPongPaddle.PetPongPaddleDirection, PongGameMode.PetPongPaddleDirection.Idle);
            Assert.IsNotNull(IPetPongPaddle.PetPongPaddlePictureBox);
            Assert.AreEqual(IPetPongPaddle.PetPongPaddleSpeed, PongGameMode.PongBallSpeed);
        }

    }
}
