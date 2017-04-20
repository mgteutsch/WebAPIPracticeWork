using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIPractice.Models;

namespace WebAPIPractice.Controllers.Interfaces
{
    public interface IVegetable
    {
        Vegetable GetVeggiesById(int veggieId);
        Vegetable GetAllVeggies();
    }
}
