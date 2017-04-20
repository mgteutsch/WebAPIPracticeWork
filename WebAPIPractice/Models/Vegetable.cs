using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIPractice.Models
{
    public class Vegetable
    {
        public string VeggieName { get; set; }
        public int VeggieQuantity { get; set; }
        public bool IsVeggieExpired { get; set; }
    }
}