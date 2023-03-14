namespace SSE
{
    public class Mode
    {
        //Little function for the random number to guess
        //normal mode is 100
        //hard mode is 1000
        static Random numberGoal = new Random();
        public static int gameMode(char x)
        {
            switch (x)
            {
                case 'h':
                    int largeGoal = numberGoal.Next(1, 1001);
                    return largeGoal;
                case 'n':
                    int smallGoal = numberGoal.Next(1, 101);
                    return smallGoal;
                default:
                    return 0;
            }
        }
    }
}