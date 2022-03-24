using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAssignment1.Models;

namespace WebApiAssignment1.Controllers
{

    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        static List<Country> CountryList = new List<Country>()
       {
            new Country{Id=1,CountryName="India",Capital="New Delhi"},
            new Country{Id=2,CountryName="China",Capital="Beijing"},
            new Country{Id=3,CountryName="France",Capital="Paris"},
            new Country{Id=4,CountryName="Germany",Capital="Berlin"},
       };

        [HttpGet]

        //Get
        [Route("CountryDetails")]

        public IEnumerable<Country> Get()
        {
            return CountryList;
        }

        [HttpGet]
        [Route("CountryList")]
        public HttpResponseMessage GetCountryList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, CountryList);
            return response;
        }

        public Country Post([FromBody] Country c)
        {
            CountryList.Add(c);
            return c;
        }

        //edit
        public void Put(int id, [FromBody] Country country)
        {
            CountryList[id - 1] = country;
        }

        //delete
        public void Delete(int id)
        {
            CountryList.RemoveAt(id - 1);
        }

        public IHttpActionResult GetName(int cid)
        {
            string Country = CountryList.Where(x => x.Id == cid).SingleOrDefault()?.CountryName;

            if (Country == null)
            {
                return NotFound();
            }
            return new MyResult(Country, Request);
        }


    }
}