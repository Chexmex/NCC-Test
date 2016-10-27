using NCC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace NCC_Test.Controllers
{
    public class EmployeesController : ApiController
    {

        // GET api/employees/5
        public IEnumerable <EmployeeModel>  Get(bool? id)
        {
            using (NCC_Test.Models.northwindEntities entities = new Models.northwindEntities())
            {
                var employee = entities.EmployeeGetList(id).Select
                (x => new EmployeeModel
                {
                    StartDate = x.HireDate,
                    ID =x.EmployeeID,
                    Gift = Gift(DateTime.Now.Year, x.HireDate.Value.Year),
                    YearsEmployed = DateTime.Now.Year - x.HireDate.Value.Year

                }).ToArray();

                return employee;
            }
        }


        
        public string Gift (int now, int hire)
        {

            if (now - hire == 5)
            {
                return "Employee receives a Tiffany’s pyramid";
            }

            else if (now - hire == 10)
            {
                return "Employee receives a classic time piece (watch)";
            }
            else if (now - hire == 15)
            {
                return "Employee receives a 30 day paid vacation";
            }
            else
            {
                return "Employee does not recieve a gift this year";
            }
        }

    }
}
