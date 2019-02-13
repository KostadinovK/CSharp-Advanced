using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Clinic> clinics = new List<Clinic>();
        List<Pet> pets = new List<Pet>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split().ToArray();

            switch (command[0])
            {
                case "Create":
                    if (command[1] == "Pet")
                    {
                        Pet p = new Pet(command[2], int.Parse(command[3]), command[4]);
                        pets.Add(p);
                    }else if (command[1] == "Clinic")
                    {
                        try
                        {
                            Clinic c = new Clinic(command[2], int.Parse(command[3]));
                            clinics.Add(c);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                    }

                    break;

                case "Add":

                    Pet pet = pets.FirstOrDefault(x => x.Name == command[1]);
                    Clinic clinic = clinics.FirstOrDefault(x => x.Name == command[2]);

                    Console.WriteLine(clinic?.Add(pet));

                    break;

                case "Release":

                    Console.WriteLine(clinics.FirstOrDefault(x => x.Name == command[1])?.Release());

                    break;

                case "HasEmptyRooms":

                    Console.WriteLine(clinics.FirstOrDefault(x => x.Name == command[1])?.HasEmptyRooms());
                    break;

                case "Print":

                    if (command.Length == 3)
                    {
                        Console.WriteLine(clinics.FirstOrDefault(x => x.Name == command[1])?.PrintRoom(int.Parse(command[2]) - 1));
                    }
                    else
                    {
                        Console.WriteLine(clinics.FirstOrDefault(x => x.Name == command[1])?.Print());
                    }

                    break;
            }
        }
    }
}
