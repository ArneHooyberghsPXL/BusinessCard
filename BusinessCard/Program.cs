namespace BusinessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                  _    _                   _                    _         \r\n     /\\                     | |  | |                 | |                  | |        \r\n    /  \\   _ __ _ __   ___  | |__| | ___   ___  _   _| |__   ___ _ __ __ _| |__  ___ \r\n   / /\\ \\ | '__| '_ \\ / _ \\ |  __  |/ _ \\ / _ \\| | | | '_ \\ / _ \\ '__/ _` | '_ \\/ __|\r\n  / ____ \\| |  | | | |  __/ | |  | | (_) | (_) | |_| | |_) |  __/ | | (_| | | | \\__ \\\r\n /_/    \\_\\_|  |_| |_|\\___| |_|  |_|\\___/ \\___/ \\__, |_.__/ \\___|_|  \\__, |_| |_|___/\r\n                                                 __/ |                __/ |          \r\n                                                |___/                |___/               ");
            Console.ResetColor();

            Console.WriteLine("+------------------------+");

            int length = 25;
            string opleiding = "Opleiding:";
            string classs = "Klasgroep:";
            string olod = "Leukste olod:";

            Console.Write("|" + opleiding); Console.WriteLine("Programmeren|".PadLeft(length - opleiding.Length));
            Console.Write("|" + classs); Console.WriteLine("1PROe|".PadLeft(length - classs.Length));
            Console.Write("|" + olod); Console.WriteLine("C#|".PadLeft(length - olod.Length));

            Console.WriteLine("+------------------------+");

            // groetjes van Korneel
        }
    }
}
