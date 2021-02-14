using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //string model, int power, string displacement, string efficiency
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);

                string displacement = "n/a";
                string efficiency = "n/a";


                if (input.Length == 3)
                {

                    int u;
                    bool isNumeric = int.TryParse(input[2], out u);
                    if (isNumeric)
                    {
                        displacement = input[2];

                    }
                    else
                    {
                        displacement = "n/a";
                        efficiency = input[2];
                    }
                }

                else if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);

                if (!engines.Contains(engine))
                {
                    engines.Add(engine);
                }
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string currEngine = input[1];
                Engine engine = engines.FirstOrDefault(x => x.Model == currEngine);

                string weight = "n/a";
                string color = "n/a";

                if (input.Length == 3)
                {
                    int u;
                    bool isNumeric = int.TryParse(input[2], out u);
                    if (isNumeric)
                    {
                        weight = input[2];
                    }
                    else
                    {
                        weight = "n/a";
                        color = input[2];
                    }
                }
                else if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];

                }
                Car currCar = new Car(model, engine, weight, color);
                if (!cars.Contains(currCar))
                {
                    cars.Add(currCar);
                }

            }

            foreach (var car in cars)
            {
                Car.PrintCar(car);
            }



        }

    }
}

