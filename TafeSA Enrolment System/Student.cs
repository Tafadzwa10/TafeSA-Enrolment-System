using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TafeSA_Enrolment_System
{
    public class Student : Person, IComparable<Student>
    {
        private string studentID;
        private string program;
        private DateTime dateregistered;
        private static string compareParameter = "date";

        /// <summary>
        /// Gets or sets the program the student is enrolled in.
        /// </summary>
        public string StudentProgram
        {
            get { return program; }
            set { program = value; }
        }

        /// <summary>
        /// Gets or sets the date the student registered.
        /// </summary>
        public DateTime DateRegistered
        {
            get { return dateregistered; }
            set { dateregistered = value; }
        }

        public string id { get; }



        /// <summary>
        /// Initializes a new instance of the Student class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="telnum"></param>
        /// <param name="studentID">Name of the student.</param>
        /// <param name="program">Program the student is enrolled in.</param>
        /// <param name="dateRegistered">Date the student registered.</param>
        public Student(string name, string email, int telnum, Address address, string studentID, string program, DateTime dateRegistered)
            : base(name, email, telnum, address)
        {
            this.studentID = studentID;
            this.StudentProgram = program;
            this.dateregistered = dateRegistered;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string representation of the student.</returns>
        public override string ToString()
        {
            return $"[Student Name:{Name},Student Email:{Email}, Student ID:{studentID}, Program: {StudentProgram}, DateRegistered: {DateRegistered}]";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Student other = (Student)obj;
            return this.studentID == other.studentID && this.program == other.program && this.dateregistered == other.dateregistered;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + (studentID?.GetHashCode() ?? 0);
                hash = hash * 23 + (program?.GetHashCode() ?? 0);
                hash = hash * 23 + dateregistered.GetHashCode();
                return hash;
            }
        }


        /// <summary>
        /// Compares this instance with a specified Student object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified Student.
        /// </summary>
        /// <param name="other">The student to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.</returns>
        public int CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }

            if (compareParameter == "date")
            {
                return this.DateRegistered.CompareTo(other.DateRegistered);
            }
            else
            {
                return this.studentID?.CompareTo(other.studentID) ?? 0;
            }
        }

        /// <summary>
        /// Determines whether two specified instances of Student are equal.
        /// </summary>
        public static bool operator ==(Student left, Student right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }
            if (left is null || right is null)
            {
                return false;
            }
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two specified instances of Student are not equal.
        /// </summary>
        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }

        public static void SetCompareParameter(string param)
        {
            compareParameter = param;
        }

    }
}
