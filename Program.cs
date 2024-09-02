namespace Stopwatch
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar:");

            var data = Console.ReadLine()!.ToLower();
            var type = char.Parse(data.Substring(data.Length - 1, 1));
            var time = int.Parse(data.Substring(0, data.Length - 1));
            var multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == '0')
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);
        }

        public static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Console.WriteLine(1000);
            Console.WriteLine("Go...");
            Console.WriteLine(1000);
            Console.WriteLine("Set...");
            Console.WriteLine(2500);

            Start(time);
        }

        public static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}