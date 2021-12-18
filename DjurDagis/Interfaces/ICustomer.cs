using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DjurDagis.Interfaces
{
   public interface ICustomer
    {
        [Key]
        public Guid Id { get; set; }

        public int PersonalNumber { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        public IAnimal Animal { get; set; }
        public List<IAnimal> Animals { get; set; } //Id finns i listan
    }
}
