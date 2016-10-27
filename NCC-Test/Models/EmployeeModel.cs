using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace NCC_Test.Models
{
    public class EmployeeModel
    {
        public int YearsEmployed { get; set; }
        public DateTime? StartDate { get; set; }
        public int ID { get; set; }
        public string Gift { get; set; }


    }

}