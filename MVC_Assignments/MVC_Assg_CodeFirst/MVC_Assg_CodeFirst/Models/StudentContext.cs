using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Assg_CodeFirst.Models
{
    public class StudentContext: DbContext
    {
        public StudentContext(): base("name=Students")
        {

        }

        public DbSet<Student_details_Table> Student_Details_Tables { get; set; }
    }
}