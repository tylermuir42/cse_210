class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        Console.Write(person.GetPersonInformation());
        Console.WriteLine($", Salary: ${person.GetSalary()}");
    }
    static void Main(string[] args)
    {
        //Person myPerson = new Person("Bob", "Bubba", 54, 287);
        //Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Taser, flash light, gun", "Sally", "Jones", 34, 110);
        Console.WriteLine(myPolice.GetPersonInformation());
        Console.WriteLine(myPolice.GetPersonInformation());

        Doctor myDoctor = new Doctor("Knife, Needle", "Bob", "Pain", 45, 189);
        Console.WriteLine(myDoctor.GetPersonInformation());    
        myDoctor.SetAge(46);
        myDoctor.SetWeight(195);

        Surgeon mySurgeon = new Surgeon("Surgeon", "Hammer", "Billy", "Jones", 56, 210);
        Console.WriteLine(mySurgeon.GetPersonInformation());
        mySurgeon.SetAge(57);
        mySurgeon.SetWeight(198);
        Console.WriteLine(mySurgeon.GetPersonInformation());

        Console.WriteLine("\n\n");

        List<Person> myPeople = new List<Person>();
        //myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);
        myPeople.Add(mySurgeon);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        } 
        
    }
}