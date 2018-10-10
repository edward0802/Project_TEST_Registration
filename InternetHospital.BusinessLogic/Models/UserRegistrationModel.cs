using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetHospital.BusinessLogic.Models
{
    public class UserRegistrationModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }  // doctor or patient (on Angular make method that assign the string value depending of user choice
        public string Status { get; set; }
    }
}
