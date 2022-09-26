using ConsoleApp3;
class Program
{
    static void Main()
    {
        Student s = new Student();

        Console.WriteLine(s.GetName());
        Console.WriteLine(s.GetSurname());
        Console.WriteLine(s.GetAge());

        s.SetAge(19);
        s.SetSurname("egorov");
        s.SetName("egor");

        Console.WriteLine(s.GetName());
        Console.WriteLine(s.GetSurname());
        Console.WriteLine(s.GetAge());
    }
}