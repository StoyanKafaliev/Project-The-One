using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WorkingWIthData.Models
{
    public class Students
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public string FacNumber { get; set; }
        public bool IsActive { get; set; }

        public Address Addres { get; set; }
    }
}