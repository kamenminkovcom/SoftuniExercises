using System;
using _03BarracksFactory.Attributes;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];

            try
            {
                repository.RemoveUnit(unitType);
            }
            catch
            {
                return "No such units in repository.";
            }
            return $"{unitType} retired!";
        }
    }
}
