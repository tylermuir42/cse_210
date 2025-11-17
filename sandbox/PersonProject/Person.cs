class Person
{
    private string _firstName;
    private string _lastName; 
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    private string PersonInformation()
    {
        return $"Name: {_firstName} {_lastName}, Age: {_age}, Weight: {_weight} lbs";
    }

    public string GetPersonInformation()
    {
        return PersonInformation();
    }

    public void SetAge(int age)
    {
        _age = age;
        if (_age > 0)
        {
            _age = 0;
        }
    }

    public void SetWeight(int weight)
    {
        _weight = weight;
        if (_weight > 0)
        {
            _weight = 0;
        }
    }
}