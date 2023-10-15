using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Students
    {
        public int Id { get; set; }
        public required string  Name { get; set;}
        public required string  Email { get; set;} 
        public required int  Phone { get; set;} 
        public required string  Address { get; set;} 


    }
}