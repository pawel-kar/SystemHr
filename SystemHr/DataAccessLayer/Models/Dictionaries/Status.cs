using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHr.DataAccessLayer.Models.Dictionaries
{
    public class Status : EmployeeEntity
    {
        private string v;

        public Status(string v)
        {
            this.v = v;
        }

        public string Value { get; set; }

        public override string ToString()
        {
            return v.ToUpper();
        }
    }

}
