using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjurDagis.Entities
{
    class DayCareServiceProperty : IOtherServices
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool AllAnimalsAllowed { get; set; }
        public bool TrueOrFalse { get; set; }
    }
}
