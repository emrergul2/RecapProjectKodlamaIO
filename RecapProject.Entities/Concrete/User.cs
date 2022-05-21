using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Core.Entities;

namespace RecapProject.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}