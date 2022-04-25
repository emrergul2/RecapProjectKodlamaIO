using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Entities.Abstract;

namespace RecapProject.Entities.Concrete
{
    public class Color:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}