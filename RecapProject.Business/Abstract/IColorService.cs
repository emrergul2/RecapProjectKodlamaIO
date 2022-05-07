using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Entities.Concrete;

namespace RecapProject.Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        List<Color> GetAll();
        Color Get(int colorId);
    }
}