using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Assignment2.Models;
namespace WebAPI_Assignment2.Controllers
{
    public class EmployeeController : ApiController
    {
        zensarDBEntities zdb = new zensarDBEntities();
        public IHttpActionResult GetEmployeeSalById(int eid)
        {
            var details = zdb.getEmpsalary(eid).ToList();
            return Ok(details);
        }
    }
}
