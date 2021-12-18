using DjurDagis.Factories;
using DjurDagis.Interfaces;
using System;

namespace DjurDagis.Menu
{
    internal class AnimalManager : IAnimalManager
    {
        IDatabaseUsingLists DatabaseUsingLists { get; set; }

        public AnimalManager(IDatabaseUsingLists db)
        {
            DatabaseUsingLists = db;
        }
        public void RegisterAnimal() 
        {
            IAnimal animal = AnimalFactory.Create();
            Console.WriteLine("Please, provide the Specie of the animal.");
            animal.Specie = Console.ReadLine();

            Console.WriteLine("Please, provide the Name of the animal.");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Please, provide the Age of the animal.");
            animal.Age = Convert.ToInt32(Console.ReadLine());

            DatabaseUsingLists.Animals.Add(animal);

        }
    }
}