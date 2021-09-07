using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnstrumanDunyam.Models;
using System.Net.Mail;


namespace EnstrumanDunyam.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string YourEmail { get; set; }
        public string Message { get; set; }

    }

}
