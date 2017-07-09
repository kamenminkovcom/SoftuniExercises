namespace Animals
{
    class AnimalFactory : Factory
    {
        public override Animal GetInstance(string type, string[] paramStrings)
        {
            string name = paramStrings[0];
            int age = int.Parse(paramStrings[1]);
            string gender = paramStrings.Length == 3 ? paramStrings[2] : null;

            switch (type)
            {
                case "Cat":
                    return new Cat(name, age, gender);
                case "Dog":
                    return new Dog(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);
                case "Kittens":
                    return new Kittens(name, age);
                case "Tomcat":
                    return new Tomcat(name, age);
                default:
                    return null;
            }
        }
    }
}
