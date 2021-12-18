using DjurDagis.Data;
using DjurDagis.Factories;
using DjurDagis.Interfaces;
using System;

namespace DjurDagis.Menu
{
    internal class CustomerManager : ICustomerManager
    {
        MainMenu menu = new MainMenu();
        IDataRepository db { get; set; }

        public CustomerManager(IDataRepository dataRepository)
        {
            db = dataRepository;
        }
        public void RegisterCustomer()
        {
            try
                {
                ICustomer customer = CustomerFactory.Create();
                Console.WriteLine("Please, write down your Personal Number.");
                customer.PersonalNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please, provide your First Name.");
                customer.FirstName = Console.ReadLine();

                Console.WriteLine("Please, provide your Last Name.");
                customer.LastName = Console.ReadLine();

                IAnimal animal = AnimalFactory.Create();
                Console.WriteLine("Please, provide the Specie of the animal.");
                animal.Specie = Console.ReadLine();

                Console.WriteLine("Please, provide the Name of the animal.");
                animal.Name = Console.ReadLine();

                Console.WriteLine("Please, provide the Age of the animal.");
                animal.Age = Convert.ToInt32(Console.ReadLine());

                db.SaveCustomerToDb(customer);
                db.SaveAnimalToDb(animal);

                Console.WriteLine($"Fantastic! {customer.FirstName} and {animal.Name} are now part of our world! Welcome!");
                Console.WriteLine("Press any key to go back to main menu.");
                Console.ReadKey();
                Console.Clear();
                // menu.ShowMenuOptions();
            }

            catch 
            {
                Exception exception;
                Console.WriteLine("Please, follow the instructions of the menu.");
            }



        }
    }
}