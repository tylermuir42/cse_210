class Program
{
    static void Main()
    {
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetCircleArea());
    }
}