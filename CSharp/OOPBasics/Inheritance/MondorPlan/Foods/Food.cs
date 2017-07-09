namespace MondorPlan.Foods
{
    public abstract class Food
    {
        public Food(int points)
        {
            Points = points;
        }

        public int Points { get;}
    }
}
