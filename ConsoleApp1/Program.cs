using System;

class ProjetAdd
{
    static void Main(string[] args)
    {
        N1.Nombre = int.Parse(Console.ReadLine());
        N2.Nombre = int.Parse(Console.ReadLine());
        Operation.Addition();
        Console.WriteLine(Res.Resultat);
        Console.Read();
    }
}
class Operation
{
    public static void Addition()
    {
        Res.Resultat = N1.Nombre + N2.Nombre;
    }
}
class N1
{
    public static int Nombre = 0;
}
class N2
{
    public static int Nombre = 0;
}
class Res
{
    public static int Resultat = 0;
}
