class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ca va?");
        Person myPerson = new Person("Bob", "Bubba", 54, 287);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Taser, flash light, gun", "Sally", "Jones", 34, 110);
        Console.WriteLine(myPolice.GetPoliceInformation());
        Console.WriteLine(myPolice.GetPersonInformation());

        Doctor myDoctor = new Doctor("Knife, Needle", "Bob", "Pain", 45, 189);
        Console.WriteLine(myDoctor.GetDoctorInformation());    
        myDoctor.SetAge(46);
        myDoctor.SetWeight(195);

        Surgeon mySurgeon = new Surgeon("Surgeon", "Hammer", "Billy", "Jones", 56, 210);
        Console.WriteLine(mySurgeon.GetSurgeonInformation());
        mySurgeon.SetAge(57);
        mySurgeon.SetWeight(198);
        Console.WriteLine(mySurgeon.GetSurgeonInformation());
        
    }
}