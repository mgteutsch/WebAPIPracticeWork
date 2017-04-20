using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIPractice.Controllers.Interfaces;
using WebAPIPractice.Models;

namespace WebAPIPractice.DAL
{
    public class VegetableRepository : IVegetable
    {
        public Vegetable GetAllVeggies()
        {
            return new Vegetable
            {
                VeggieName = "Celery",
                VeggieQuantity = 12,
                IsVeggieExpired = false
            };
        }

        public Vegetable GetVeggiesById(int veggieId)
        {
            if (veggieId == 0) return null;

            return new Vegetable
            {
                VeggieName = "Carrot",
                VeggieQuantity = 8,
                IsVeggieExpired = false
            };  
        }
    }
}