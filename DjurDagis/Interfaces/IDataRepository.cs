using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;

namespace DjurDagis.Data
{
    interface IDataRepository
    {
        IDatabaseUsingLists db { get; set; }

        List<IDayCareService> GetAllServices();
        List<IDayCareService> GetAllServicesByPrice(IDayCareService dayCareService);
        IDayCareService GetServiceByAnimal(IAnimal animal);
        IDayCareService GetServiceByCustomer(ICustomer customer);
        IDayCareService GetServiceByGuid(Guid guid);
        IDayCareService GetServiceByName(string serviceName);
        IDayCareService GetServiceByNumber(int serviceNumber);
        ICustomer GetCustomerByPersonalNumber(int personalNumber);
        void SaveCustomerToDb(ICustomer customer);
        void SaveAnimalToDb(IAnimal animal);
        
    }
}