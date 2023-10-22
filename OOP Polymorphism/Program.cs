namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri rektangel = new Rektangel();
            Geometri fyrkant = new Fyrkant();
            Geometri parallellogram = new Parallellogram();
            Geometri cirkel = new Cirkel();
            Geometri ellips = new Ellips();

            Console.WriteLine("Area Rektangel: " + rektangel.Area());
            Console.WriteLine("Area Fyrkant: " + fyrkant.Area());
            Console.WriteLine("Area Parallellogram: " + parallellogram.Area());
            Console.WriteLine("Area Cirkel: " + cirkel.Area());
            Console.WriteLine("Area Ellips: " + ellips.Area());

            Console.WriteLine();
            Console.Write("Press Any Key To Exit The Program: ");
            Console.ReadKey();
        }
    }
}