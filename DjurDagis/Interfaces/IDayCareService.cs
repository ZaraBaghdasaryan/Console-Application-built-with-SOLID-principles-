using DjurDagis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DjurDagis.Interfaces
{
   public interface IDayCareService
    {
        [Key]
        public Guid Id { get; set; }
        public int Number { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public string Price { get; set; } //Since I want everything to be free

       // public bool AllAnimalsAllowed { get; set; }

        public List<ICustomer> Customers { get; set; }

        public List<IAnimal> Animals { get; set; } //Add any animal you like later
        public List<IOtherServices> OtherServices { get; set; }
    }
}
