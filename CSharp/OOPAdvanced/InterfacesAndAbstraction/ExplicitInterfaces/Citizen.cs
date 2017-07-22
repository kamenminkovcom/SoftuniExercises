using System.Text;

public class Citizen : IPerson, IResident
{
    public Citizen(string name, int age, string country)
    {
        this.Name = name;
        this.Age = age;
        this.Country = country;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Country { get; set; }

    string IPerson.GetName() => Name;

    string IResident.GetName() => "Mr/Ms/Mrs";

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine((this as IPerson).GetName());
        sb.Append((this as IResident).GetName() + " " + Name);
        return sb.ToString();
    }
}


