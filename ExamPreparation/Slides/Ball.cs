namespace Slides
{
    internal class Ball
    {
        public int BallWidth { get; set; }

        public int BallHeight { get; set; }

        public int BallDepth { get; set; }

        public Ball(Ball ball)
        {
            this.BallWidth = ball.BallWidth;
            this.BallHeight = ball.BallHeight;
            this.BallDepth = ball.BallDepth;
        }

        public Ball(int ballWidth, int ballHeight, int ballDepth)
        {
            this.BallWidth = ballWidth;
            this.BallHeight = ballHeight;
            this.BallDepth = ballDepth;
        }
    }
}