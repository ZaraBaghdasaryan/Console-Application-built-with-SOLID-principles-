using DjurDagis.Data;
using DjurDagis.Entities;
using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DjurDagis.Menu
{
    internal class BookingsManager : IBookingsManager
    {
        public IDataRepository db { get; set; }
      //  public IDayCareService ds { get; set; }

        public BookingsManager(IDataRepository dataRepository /*IDayCareService dayCareService*/)
        {
            db = dataRepository;
            //ds = dayCareService;
        }

        public void RegisterBooking()
        {
            Console.WriteLine("Please, write down your Personal Number.");
            ICustomer customer = db.GetCustomerByPersonalNumber(Convert.ToInt32(Console.ReadLine()));
            //Console.ReadKey();
            Console.WriteLine("Please, choose a Day Care Service Number to add.");
            IDayCareService dayCareService = db.GetServiceByNumber(Convert.ToInt32(Console.ReadLine()));

            dayCareService.Customers.Add(customer);

            Console.WriteLine("The service has been added to your list of purchases."); //TODO: fix the string interpolation
            Console.WriteLine(" Press any key to go back to main menu.");
            Console.ReadKey();
            Console.Clear();



            //Ideas on how to show a list of services that the customer could choose from

            //IEnumerable<DayCareService> displayServices()
            //{
            //    DatabaseUsingLists db = new DatabaseUsingLists();

            //    var careServicesFromDb = db.Services.ToList();
            //    for (int i = 0; i < careServicesFromDb.Count; i++)
            //    {
            //        var careServices = careServicesFromDb[i];
            //        Console.WriteLine($"Name: {careServices.Name}\n Description: {careServices.Description}" +
            //            $"\n Price: {careServices.Price} \n All Animals Allowed: {careServices.AllAnimalsAllowed}");
            //    }

            //    return (IEnumerable<DayCareService>)careServicesFromDb;

            //    Console.WriteLine("Please, write the name of the service you would like to choose.");
            //    IDayCareService dayCareService = (IDayCareService)db.Services.Where
            //        (dayCareService => dayCareService.Name == Console.ReadLine().FirstOrDefault().ToString());
            //    dayCareService.Customers.Add(customer);

            //    Console.WriteLine($"{dayCareService} has been added to your list of purchases.");
            //    Console.WriteLine(" Press any key to go back to main menu.");
            //    Console.ReadKey();
            //    Console.Clear();

            //}


        }
    }
}