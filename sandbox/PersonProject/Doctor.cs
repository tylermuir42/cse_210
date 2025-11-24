using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Doctor : Person
{
    private string _tools = "";
    public Doctor(string tools, string firstName, string lastName, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()}, Tools: {_tools}";
    }

    //This inherits from Doctor so this isn't totally necseeary.
    public override double GetSalary()
    {
        return 80000.00;
    }
}