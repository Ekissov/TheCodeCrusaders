using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string lastName, string phoneNumber, string email, int postalCode, string city, string address, int customerID) 
        { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.PostalCode = postalCode;
            this.City = city;
            this.Email = email;
            this.CustomerID = customerID;
        }

        public Customer(string firstName, string lastName, string phoneNumber, string email, int postalCode, string city, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.PostalCode = postalCode;
            this.City = city;
            this.Email = email;
        }

        public Customer(int customerID) 
        {
        this.CustomerID = customerID;
        }

     
    }
}
