using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DjurDagis.Entities
{
    public class Animal : IAnimal
    {
        public Guid Id { get; set; }
        public string Specie { get; set ; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<ICustomer> Customers { get; set; } //Association is already established

        public Animal()
        {
            Id = Guid.NewGuid();
        }
    }
}