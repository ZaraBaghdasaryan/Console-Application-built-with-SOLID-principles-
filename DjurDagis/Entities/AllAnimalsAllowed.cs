using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurDagis.Entities
{
    public class AllAnimalsAllowed : IOtherServices
    {
        public string Name => "All animals allowed.";
        public string Description => "All animals are allowed in the day care.";
        public string Price => "Free!";
        public bool TrueOrFalse { get; set; }

        public AllAnimalsAllowed()
        {

        }
    }
}
