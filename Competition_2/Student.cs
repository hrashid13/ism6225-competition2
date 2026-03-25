using System;
using System.Collections.Generic;
using System.Text;

namespace Competition_2
{
    public class Student : Person
{
    public string Major { get; set; }
    public int GraduationYear { get; set; }

    public Student(string name, string email, string id, string major, int gradYear)
        : base(name, email, id)
    {
        Major = major;
        GraduationYear = gradYear;
    }
}
}
