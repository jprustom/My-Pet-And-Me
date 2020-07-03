namespace My_Pet_And_Me__
{
    public interface IManageBallFaçade
    {
        void MoveBall(Ball ball);
        void IfBallHitEdges(Ball ball);
        void IfBallHitPetPaddle(Ball ball);
    }
}