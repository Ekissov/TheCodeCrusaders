using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    public class Costumer
    {
        public int CostumerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

        public Costumer(string firstName, string lastName, string phoneNumber, string address, int postalCode, string city, string email) 
        { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.PostalCode = postalCode;
            this.City = city;
            this.Email = email;
        }
    }
}
