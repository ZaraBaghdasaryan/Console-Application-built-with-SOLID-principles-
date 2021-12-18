using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurDagis.Data
{
    //Implemented repository pattern to follow the lego logic

    class DataRepository : IDataRepository
    {
        public IDatabaseUsingLists db { get; set; }

        public DataRepository(IDatabaseUsingLists databaseUsingLists)
        {
            db = databaseUsingLists;
        }

        public IDayCareService GetServiceByName(string serviceName)
        {
            return db.Services.Where(dsc => dsc.Name == serviceName).FirstOrDefault();

        }

        public IDayCareService GetServiceByNumber(int serviceNumber)
        {
            return db.Services.Where(dcs => dcs.Number == serviceNumber).FirstOrDefault();
        }

        public IDayCareService GetServiceByGuid(Guid guid)
        {
            return db.Services.Where(dsc => dsc.Id == guid).FirstOrDefault();
        }

        public IDayCareService GetServiceByCustomer(ICustomer customer)
        {
            return db.Services.Where(dsc => dsc.Customers.Contains(customer)).FirstOrDefault();
        }

        public IDayCareService GetServiceByAnimal(IAnimal animal)
        {
            return db.Services.Where(dsc => dsc.Animals.Contains(animal)).FirstOrDefault();
        }

        public List<IDayCareService> GetAllServicesByPrice(IDayCareService dayCareService)
        {
            return db.Services.Where(dsc => dsc.Price == dayCareService.Price).ToList();
        }

        public List<IDayCareService> GetAllServices()
        {
            return db.Services.ToList();
        }

        public ICustomer GetCustomerByPersonalNumber(int personalNumber)
        {
            return db.Customers.Where(c => c.PersonalNumber == personalNumber).FirstOrDefault();
        }

        public void SaveCustomerToDb(ICustomer customer)
        {
            db.Customers.Add(customer);
        }

        public void SaveAnimalToDb(IAnimal animal)
        {
            db.Animals.Add(animal);
        }
    }
}
