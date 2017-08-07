using _03BarracksFactory.Attributes;

namespace _03BarracksFactory.Core.Commands
{
    using System;
    using System.Linq;
    using System.Reflection;
    using _03BarracksFactory.Contracts;

    public class CommandInterpretator : ICommandInterpreter
    {
        public CommandInterpretator(IRepository repository, IUnitFactory factory)
        {
            Factory = factory;
            Repository = repository;
        }

        private IRepository Repository { get; }
        private IUnitFactory Factory { get; }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            commandName = commandName.First().ToString().ToUpper() + commandName.Substring(1);
            Type commandType = Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name == commandName + "Command");
            var instance =  Activator.CreateInstance(commandType, new object[] { data}) as Command;
            return InjectDepedacies(instance);
        }

        private IExecutable InjectDepedacies(IExecutable instance)
        {
            var filedsToInject = instance.GetType()
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => x.GetCustomAttributes(typeof(InjectAttribute)) != null)
                .ToArray();

            var localProps = GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in filedsToInject)
            {
                field.SetValue(instance,localProps.First(x => x.PropertyType == field.FieldType).GetValue(this));
            }

            return instance;
        }
    }
}
