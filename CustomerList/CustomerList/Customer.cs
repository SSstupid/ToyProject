using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList
{
    public class Customer
    {
        public String FirstName;
        public String LastName;
        public String Address;
        public String Description;
        private DateTime _Birthday;
        private bool _IsQualified;
        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = Age >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set 
            {
                _Birthday = value;
                _IsQualified = Age >= 18;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }


    }
}
