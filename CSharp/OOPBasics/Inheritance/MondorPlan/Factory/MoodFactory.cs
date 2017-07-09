using MondorPlan.Moods;

namespace MondorPlan.Factory
{
    public class MoodFactory
    {
        public Mood CreateInstance(int points)
        {
            if (points < -5)
                return new Angry(points);
            if (points < 0)
                return new Sad(points);
            if (points < 15)
                return new Happy(points);
            return new JavaScript(points);
        }
    }
}
