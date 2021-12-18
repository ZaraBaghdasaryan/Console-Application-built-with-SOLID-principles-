using DjurDagis.Entities;
using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurDagis.Factories
{
   static class CustomerFactory
    {
      public static ICustomer Create()
        {
            return new Customer();
        }
    }
}
