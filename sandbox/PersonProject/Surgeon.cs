using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Surgeon : Doctor
{
    private string _title = "";
    public Surgeon(string title, string tools, string firstName, string lastName, int age, int weight)
    : base (tools, firstName, lastName, age, weight)
    {
        _title = title;
    }


    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()}, TItle: {_title}";
    }

    public override double GetSalary()
    {
        return base. GetSalary() + 150000.00;
    }
}