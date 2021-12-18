using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace DjurDagis.Menu
{
    class MainMenu : IMainMenu
    {
        ICustomerManager CustomerManager { get; set; }
        IBookingsManager BookingsManager { get; set; }
        public MainMenu(IBookingsManager bm, ICustomerManager cm)
        {
            BookingsManager = bm;
            CustomerManager = cm;
        }

        public MainMenu()
        {
        }

        public void ShowMenuOptions() 
        {
            Console.WriteLine("         | *************************************************************** | ");
            Console.WriteLine();
            Console.WriteLine("         |  Welcome to the best Animal Day Care Service in the world!      |");
            Console.WriteLine();
            Console.WriteLine("         | *************************************************************** |");
            Console.WriteLine();
            Console.WriteLine("Here you will find the most exciting adventures for your beloved friends and family!");
            Console.WriteLine();
            Console.WriteLine("                  Choose the options below to start your journey.");
            Console.WriteLine("                                         ***");
            Console.WriteLine("                 |Press 1 for registering yourself as a new customer.|");
            Console.WriteLine("                 |Press 2 for booking a wonderful day care service.  |");

            
        }

        public void GetUserInput()
        {
            var userInput = Console.ReadKey(true).Key; //To take the input, process it, but not show it to the user
            switch (userInput)
            {
               
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    CustomerManager.RegisterCustomer();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    BookingsManager.RegisterBooking();
                    break;
                default:
                    Console.WriteLine("Please, choose only the above-mentioned commands.");
                    break;

               
            }
        }

        public void ChoochooTrain()
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (j == 29)
                    {
                        Console.Clear();
                    }
                    else
                    {


                        // steam
                        Console.Write("       . . . . o o o o o o", System.Drawing.Color.LightGray);
                        for (int s = 0; s < j / 2; s++)
                        {
                            Console.Write(" o", System.Drawing.Color.LightGray);
                        }
                        Console.WriteLine();

                        var margin = "".PadLeft(j);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(margin + "                _____      o", Color.LightGray);
                        Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Color.DeepSkyBlue);
                        Console.WriteLine(margin + "      [________]_|__|________)< ", Color.DeepSkyBlue);
                        Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Color.Blue);
                        Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);

                        Console.SetCursorPosition(0, 0);

                        Thread.Sleep(200);
                    }
                }
            }
        }
    }
}
