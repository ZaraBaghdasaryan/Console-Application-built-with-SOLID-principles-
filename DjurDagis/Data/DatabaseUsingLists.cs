using DjurDagis.Entities;
using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DjurDagis
{
   public class DatabaseUsingLists : IDatabaseUsingLists
    {
        public List<IDayCareService> Services { get; set; }
        public List<ICustomer> Customers { get; set; }
        public List<IAnimal> Animals { get; set; }

        public DatabaseUsingLists() //Create the actual lists to able to add to the database
        {
            Services = new List<IDayCareService>();
            Customers = new List<ICustomer>();
            Animals = new List<IAnimal>();
        }
    }
}
