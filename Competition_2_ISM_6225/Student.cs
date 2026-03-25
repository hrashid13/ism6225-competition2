namespace Competition_2_ISM_6225
{
    public class Student
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
