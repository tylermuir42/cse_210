class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Tyler", "Muir", 30, 200);
        Console.WriteLine(person.GetPersonInformation());

        Police police1 = new Police("Taser, Gun", "John", "Doe", 35, 220);
        Console.WriteLine(police1.GetPoliceInformation());
        Console.WriteLine(police1.GetPersonInformation());
    }
}