using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSA_Enrolment_System
{
    internal class Enrollment
    {
        static readonly DateTime DEF_DATE_ENROLLED = new DateTime(1997, 2, 23);
        const string DEF_GRADE = "Not Graded yet";
        const string DEF_SEMESTER = "No comenced yet";

        private DateTime date_enrolled;
        private string grade;
        private string semester;
        public Subject Subject { get; set; }

        public DateTime EnrollmentDate
        {
            get
            { return date_enrolled; }
            set
            { date_enrolled = value; }
        }

        public string EnrollmentGrade
        {
            get
            { return grade; }
            set
            { grade = value; }
        }

        public string EnrollmentSemester
        {
            get
            { return semester; }
            set
            { semester = value; }
        }



        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {

        }

        public Enrollment(DateTime date_enrolled, string grade, string semester, Subject subject)
        {
            EnrollmentDate = date_enrolled;
            EnrollmentGrade = grade;
            EnrollmentSemester = semester;
            Subject = subject;
        }

        public Enrollment(DateTime dEF_DATE_ENROLLED, string dEF_GRADE, string dEF_SEMESTER)
        {
        }
    }
}
