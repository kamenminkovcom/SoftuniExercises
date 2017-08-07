namespace _03BarracksFactory.Core.Commands
{
    using _03BarracksFactory.Contracts;

    public abstract class Command : IExecutable
    {
        public Command(string[] data)
        {
            Data = data;
        }

        protected string[] Data { get; }

        public abstract string Execute();
    }
}
