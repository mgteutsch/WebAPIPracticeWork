using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebAPIPractice.Controllers.Interfaces;
using WebAPIPractice.DAL;
using WebAPIPractice.Models;

namespace WebAPIPractice.Controllers
{
    public class VegetableController : ApiController
    {
        readonly IVegetable _veggieRepo;

        public VegetableController()
        {
            _veggieRepo = new VegetableRepository(); 
        }

        public VegetableController(IVegetable veggieRepo)
        {
            _veggieRepo = veggieRepo;         
        }

        /*
        [HttpGet]
        [Route("api/vegetable")]
        //public HttpResponseMessage
        */


        //Post
        [HttpPost]
        [Route("api/vegetable")]
        public HttpResponseMessage PostVeggies([FromBody] Vegetable veggie)
        {
            return Request.CreateResponse(HttpStatusCode.OK, veggie);
        }



    }
}