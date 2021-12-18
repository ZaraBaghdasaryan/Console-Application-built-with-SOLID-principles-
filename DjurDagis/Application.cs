using DjurDagis.Entities;
using DjurDagis.Interfaces;
using DjurDagis.Menu;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DjurDagis
{
    class Application : IApplication
    {
        public IMainMenu MainMenu { get; set; }

        public IDatabaseUsingLists Db { get; set; } //Dependency injection
        public IConfiguration Configuration { get; }


        //TODO: Remove this too before delivery
        public IMockData MockData { get; set; }


        public Application(IMainMenu mainMenu, IDatabaseUsingLists databaseUsingLists, IMockData mockData) 
        {
            MainMenu = mainMenu; 
            Db = databaseUsingLists;
            MockData = mockData;
            //Configuration = configuration;
          

        }
        // This method gets called by the runtime. Use this method to add services to the container.

        public void Run()
        {
            //TODO: Remove before delivery
            //Creating the services
            MockData.CreateDayCareServices();

            //Registering customers

            while (true)
            {
                MainMenu.ShowMenuOptions();
                MainMenu.GetUserInput();
               // MainMenu.ChoochooTrain();

            }
        }
       
    }
}


