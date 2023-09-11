﻿using TwoWheelTrader.Core.Interfaces;
using TwoWheelTrader.Models.Enduro;
using TwoWheelTrader.Models.Interfaces;
using TwoWheelTrader.Models.Motocross;

namespace TwoWheelTrader.Core
{
    public class Engine : IEngine
    {
        private IController controller;

        public Engine()
        {
            controller = new Controller();   
        }

        public void RunProgram()
        {
            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                try
                {
                    string output = string.Empty;
                    string command = input[0];

                    if (command == "done")
                    {
                        Environment.Exit(0);
                    }
                    else if (command == "add")
                    {
                        // 1 = YAMAHA / 2 = YZF / 3 = 250 / 4 = 2019 / 5 = 33000 (FOREIGN PRICE - PRE-CONVERT)

                        string make = input[1];
                        string model = input[2];
                        int cc = int.Parse(input[3]);
                        int year = int.Parse(input[4]);
                        int foreignPrice = int.Parse(input[5]);

                        if (make == "yam" || make == "yamaha")
                        {
                            if (model == "yzf")
                            {
                                IMotorcycle yamaha = new Models.Motocross.Yamaha(model, cc, year, foreignPrice);
                                controller.Add(yamaha);
                            }
                        }
                        else if (make == "hon" || make == "honda")
                        {
                            if (model == "crf")
                            {
                                IMotorcycle honda = new Models.Motocross.Honda(model, cc, year, foreignPrice);
                                controller.Add(honda);
                            }
                        }
                    }
                    else if (command == "remove")
                    {
                        // Once the program is connected to the MS SQL this command should become a viable option
                        // I will need primary keys, need to find what hold the bikes apart, besides the primary key, like a web link
                    }
                    else if (command == "check")
                    {
                        // Check if the current model exists
                        // By primary key or ID
                    }
                    else if (command == "update")
                    {
                        // When a change of some property is needed, usually the price - when the motorcycle has had a discount
                        // Again - must search by link (???), or by primary key if I learn DB until then
                    }
                    else
                    {
                        Console.WriteLine("Invalid command. Try again!");
                    }
                    // TO ADD MORE ELSE IFS BASED ON DIFFERENT SCENARIOS
                    // 
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}