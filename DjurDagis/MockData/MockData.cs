using DjurDagis.Entities;
using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DjurDagis
{
    public class MockData : IMockData
    {
        public IDatabaseUsingLists db { get; set; }  //Injections
        public MockData(IDatabaseUsingLists databaseUsingLists) //Connection to database
        {
            db = databaseUsingLists;
        }
        public void CreateDayCareServices()

        {
            for (int i = 0; i < 10; i++)
            {
                //Create DayCareServices
                var service = new DayCareService();
                service.Number = i;
                service.Name = "Paradise for dogs";
                service.Description = "Swimming pool with an amusement park all for dogs big and small!";
                //IOtherServices allAnimalsAllowed = new AllAnimalsAllowed();
                //allAnimalsAllowed.TrueOrFalse = false;
                //service.OtherServices.Add(allAnimalsAllowed);
                service.Price = "free";
                db.Services.Add(service);

                var service2 = new DayCareService();
                service2.Number = i;
                service2.Name = "Paradise for cats";
                service2.Description = "The fluffiest, cuddliest and most fun environment for your cat to play in.";
                //IOtherServices allAnimalsAllowed2 = new AllAnimalsAllowed();
                //allAnimalsAllowed2.TrueOrFalse = false;
                //service2.OtherServices.Add(allAnimalsAllowed2);
                service2.Price = "free";
                db.Services.Add(service2);

                var service3 = new DayCareService();
                service3.Number = i;
                service3.Name = "Paradise for octopuses";
                service3.Description = "Most fascinating, exciting, filled with endless intellectual puzzles and challenges for your little octopus to marvel in.";
                //IOtherServices allAnimalsAllowed3 = new AllAnimalsAllowed();
                //allAnimalsAllowed3.TrueOrFalse = false;
                //service3.OtherServices.Add(allAnimalsAllowed3);
                service3.Price = "free";
                db.Services.Add(service3);

                var service4 = new DayCareService();
                service4.Number = i;
                service4.Name = "Paradise for all our lovely friend animals";
                service4.Description = "A wild natural world where all living beings feel at home.";
                //IOtherServices allAnimalsAllowed4 = new AllAnimalsAllowed();
                //allAnimalsAllowed4.TrueOrFalse = true;
                //service4.OtherServices.Add(allAnimalsAllowed4);
                service4.Price = "free";
                db.Services.Add(service4);
            }

        }
    }
}
