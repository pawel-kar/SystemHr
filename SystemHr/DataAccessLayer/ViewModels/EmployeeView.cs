﻿namespace SystemHr.DataAccessLayer.ViewModels
{
    public class EmployeeView
    {
        public long Id { get; set; }
        
        private string lastName;
        public string LastName
        {
            get { return lastName.ToUpper(); }
            set { lastName = value; }                
        }
       
        private string firstName;
        public string FirstName 
        {
            get { return firstName.ToUpper(); }
            set { firstName = value; }
        }
        private string code;

        public string Code 
        {
            get { return code.PadLeft(4, '0'); }
            set{ code = value; }
        }
        public string Position { get; set; }
        public string Status { get; set; }

    }
}
