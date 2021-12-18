using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DjurDagis.Interfaces
{
   public interface IAnimal
    {   [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(20)]
        public string Specie { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
        
    }
}
