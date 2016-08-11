using MVC_WorkingWIthData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_WorkingWIthData.InputModels
{
    public class StudentsInput
    {
        [Required]
        [MinLength(3,ErrorMessage ="{0} need to be min {1} charackters")]
        [MaxLength(25,ErrorMessage ="{0} need to be max {1} charackters")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Range(2,6,ErrorMessage ="{0} need to be between {1} and {2}")]
        public int Grade { get; set; }

        [Range(12,12,ErrorMessage ="{0} need to be equals to {1}")]
        public string FacNumber { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public Address Addres { get; set; }

    }
}