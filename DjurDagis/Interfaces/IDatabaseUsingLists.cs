using DjurDagis.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DjurDagis.Interfaces
{
    public interface IDatabaseUsingLists //Had to add the same code from DatabaseUsingLists, since db.Services.Add(service); wasn't working in the application class
    {
        public List<IDayCareService> Services { get; set; }
        public List<ICustomer> Customers { get; set; }
        public List<IAnimal> Animals { get; set; }
    }
}
