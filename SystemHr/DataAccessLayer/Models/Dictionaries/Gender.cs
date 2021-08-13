using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHr.DataAccessLayer.Models.Dictionaries
{
    public class Gender : EmployeeEntity
    {
        public string Value { get; set; }

        public Gender(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }

    
}
