namespace Animals
{
    abstract class Factory
    {
        public abstract Animal GetInstance(string type, string[] paramStrings);
    }
}
