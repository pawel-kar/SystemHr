using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHr.DataAccessLayer.Models.Dictionaries;

namespace SystemHr.DataAccessLayer.Models
{
    public class Employee : EmployeeEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Code { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateBirth { get; set; }
        public string PESEL { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IdentityCardNumber { get; set; }

        public DateTime? IssueDateIdentityCard { get; set; }

        public DateTime? ExpirationDateIdentityCard { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? IssueDatePassport { get; set; }
        public DateTime? ExpirationDatePassport { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
