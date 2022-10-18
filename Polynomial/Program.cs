namespace Polynomial;
class Program
{
    static void Main(string[] args)
    {
        Polynomial p1 = new Polynomial();
        p1.AddTerm(5, 4);
        Console.WriteLine(p1);
    }
}

