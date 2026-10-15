namespace BusinessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Arne Hooyberghs".PadLeft(25));
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();

            int length = 25;
            string opleiding = "Opleiding:";
            string classs = "Klasgroep:";
            string olod = "Leukste olod:";

            Console.Write(opleiding); Console.WriteLine("Programmeren".PadLeft(length - opleiding.Length));
            Console.Write(classs); Console.WriteLine("1PROe".PadLeft(length - classs.Length));
            Console.Write(olod); Console.WriteLine("C#".PadLeft(length - olod.Length));
        }
    }
}
