using System;
namespace lesson2_myProject
{
    class Bird
    {
        private string _species;
        private string _color;
        private double _lifespan;

        public Bird()
        {
            _species = "";
            _color = "";
            _lifespan = 0;
        }
        public Bird(string species, string color, double lifespan)
        {
            _species = species;
            _color = color;
            _lifespan = lifespan;
        }
        public string GetSpecies()
        {
            return _species;
        }
        public void SetSpecies(string species)
        {
            _species = species;
        }
        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }
        public double GetLifespan()
        {
            return _lifespan;
        }
        public void SetLifespan(double lifespan)
        {
            _lifespan = lifespan;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            bird1.SetSpecies("Northern Cardinal");
            bird1.SetColor("red");
            bird1.SetLifespan(3);

            Bird bird2 = new Bird("Black-Capped Chickadee", "white/gray/black", 2);

            Bird bird3 = new Bird();
            bird3.SetSpecies(InputValidString("Please enter the species of bird: "));
            bird3.SetColor(InputValidString("Please enter the color(s) of the bird: "));
            bird3.SetLifespan(InputValidDouble("Please enter the lifespan of the bird (in years): "));

            Console.WriteLine();

            string species = InputValidString("Please enter the species of bird: ");
            string color = InputValidString("Please enter the color(s) of the bird: ");
            double lifespan = InputValidDouble("Please enter the lifespan of the bird (in years): ");
            Bird bird4 = new Bird(species, color, lifespan);

            PrintBirdInfo(bird1);
            PrintBirdInfo(bird2);
            PrintBirdInfo(bird3);
            PrintBirdInfo(bird4);

            Console.ResetColor();
        }

        static void PrintBirdInfo(Bird bird)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n~*~*~*~ Bird Info ~*~*~*~");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Species:  {bird.GetSpecies()}");
            Console.WriteLine($"Color(s):  {bird.GetColor()}");
            Console.WriteLine($"Lifespan:  {bird.GetLifespan()} year(s)\n");
        }

        static string InputValidString(string message)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(message);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No blank strings allowed. Please try again.");
                    continue;
                }
            }
        }
        static double InputValidDouble(string message)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(message);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string input = Console.ReadLine();
                if (double.TryParse(input, out double doubleInput))
                {
                    return doubleInput;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please input a number.");
                    continue;
                }
            }
        }
    }
}
