using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Assg_CodeFirst.Models
{
      
        [Table("Student_details_Table")]

        public class Student
        {
            [Key]
            public int StudentId { get; set; }
            public int id { get;set; }
            public string Branch { get; set; }
            public string City { get; set; }
            public float Percentage { get; set; }
        }
    
}