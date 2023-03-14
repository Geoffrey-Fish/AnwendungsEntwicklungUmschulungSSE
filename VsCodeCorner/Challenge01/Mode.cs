using static System.Console;
namespace SSE
{
    public class Mode
    {
        static Random numberGoal = new Random();
        public static int gameMode(char x)
        {
            switch (x)
            {
                case 'y':
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