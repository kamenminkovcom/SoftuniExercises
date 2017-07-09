using System.Text;

namespace MondorPlan.Moods
{
    public abstract class Mood
    {
        public Mood(int points)
        {
            this.Points = points;
        }

        public int Points { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{Points}")
                .Append($"{GetType().Name}");
            return result.ToString();
        }
    }
}
