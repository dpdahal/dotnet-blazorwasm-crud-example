using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Students
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required]

        public required string Email { get; set; }
        [Required]

        public required string Phone { get; set; }
        [Required]

        public required string Address { get; set; }


    }
}