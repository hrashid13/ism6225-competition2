using System;
using System.Collections.Generic;
using System.Text;

namespace Competition_2
{
    internal class Staff
    {
        public string Position { get; set; }
        public string Department { get; set; }

        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            Position = position;
            Department = department;
        }
    }
}
