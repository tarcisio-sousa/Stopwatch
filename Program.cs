namespace Stopwatch
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar:");

            var data = ReadData();

            if (data == "0")
            {
                Exit();
            }

            var time = new Time(data);

            PreStart(time.Interval);
        }

        private static string ReadData()
        {
            return Console.ReadLine()!.ToLower();
        }

        public static void Exit(int exitCode = 0)
        {
            Environment.Exit(exitCode);
        }

        public static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        public static void Start(int time)
        {
            Timing(time);

            DisplayFinishedTiming();
        }

        private static void Timing(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }

        private static void DisplayFinishedTiming()
        {
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }
    }
}