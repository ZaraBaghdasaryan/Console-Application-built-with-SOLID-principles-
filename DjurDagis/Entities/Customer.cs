using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DjurDagis.Entities
{
    public class Customer : ICustomer
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

        public Customer()
        {
            Id = Guid.NewGuid();
        }
    }
}

//TODO: Think about configuring the relation between Customer and Animal
//so that the booking can show both at the same time
