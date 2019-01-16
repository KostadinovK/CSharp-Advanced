﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int greenLightSeconds = int.Parse(Console.ReadLine());
        int freeWindowSeconds = int.Parse(Console.ReadLine());

        string line = Console.ReadLine();

        Queue<string> cars = new Queue<string>();
        string passingCar = string.Empty;
        int crashIndex = -1;
        int passedCars = 0;
        while (line != "END")
        {

            if (line == "green")
            {
                int elapsedSeconds = 0;
                while (elapsedSeconds < greenLightSeconds && cars.Any())
                {
                    string car = cars.Peek();
                    if (elapsedSeconds + car.Length <= greenLightSeconds)
                    {
                        elapsedSeconds += car.Length;
                        cars.Dequeue();
                        passedCars++;
                    }
                    else
                    {
                        int remainingTime = car.Length + elapsedSeconds - greenLightSeconds;
                        if (remainingTime <= freeWindowSeconds)
                        {
                            cars.Dequeue();
                            passedCars++;
                            break;
                        }
                        else
                        {
                            passingCar = car;
                            crashIndex = car.Length - (remainingTime - freeWindowSeconds);
                            break;
                        }
                    }
                }
            }
            else
            {
                cars.Enqueue(line);
            }

            if (passingCar != string.Empty)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{passingCar} was hit at {passingCar[crashIndex]}.");
                break;
            }

            line = Console.ReadLine();
        }

        if (passingCar == string.Empty)
        {
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }


    }
}
