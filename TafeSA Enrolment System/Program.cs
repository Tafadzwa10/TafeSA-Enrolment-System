using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSA_Enrolment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //public Student(string name, string email, int telnum, Address address, string studentID, string program, DateTime dateRegistered)
        //public Address(int streetnum, string streetname, string suburb, int postcode, string state)


            List<Student> students = new List<Student>
            {
                new Student("Tapiwa Muzanenhamo", "TMuzanenhamo@gmail.com", 0773463899, new Address(18, "Highview", "Hillbank", 5112, "SA"), "0011", "Technical Drawing", new DateTime(2022, 1, 15)),
                new Student("Eric Tsungano", "Erictsungano@gmail.com", 0772625899 , new Address(18, "Modbury", "Glen", 5101, "WA"), "0012", "Theological Studies", new DateTime(2023, 7, 1)),
                new Student("Tapiwa Muzanenhamo", "TMuzanenhamo@gmail.com", 0773463899, new Address(18, "Highview", "Hillbank", 5112, "SA"), "0011", "Technical Drawing", new DateTime(2022, 1, 15)),
                new Student("Steve Mabasa", "SteveMabasa@yahoo.com", 0773012899, new Address(18, "Salisbury", "North", 5012, "NW"), "0014", "Philosophy", new DateTime(2021, 6, 30)),
            };

            // Test ToString
            Console.WriteLine("Testing ToString:");
            students.ForEach(student => Console.WriteLine(student.ToString()));

            // Test Equals
            Console.WriteLine("\nTesting Equals:");
            Console.WriteLine($"First and second student are equal: {students[0].Equals(students[1])}");
            Console.WriteLine($"First and third student are equal: {students[0].Equals(students[2])}");

            // Test == and !=
            Console.WriteLine("\nTesting == and !=:");
            Console.WriteLine($"First and second student are equal using ==: {students[0] == students[1]}");
            Console.WriteLine($"First and third student are equal using ==: {students[0] == students[2]}");
            Console.WriteLine($"First and second student are not equal using !=: {students[0] != students[1]}");
            Console.WriteLine($"First and third student are not equal using !=: {students[0] != students[2]}");

            // Test GetHashCode
            Console.WriteLine("\nTesting GetHashCode:");
            Console.WriteLine($"HashCode of first student: {students[0].GetHashCode()}");
            Console.WriteLine($"HashCode of second student: {students[1].GetHashCode()}");
            Console.WriteLine($"HashCode of third student (should be same as first): {students[2].GetHashCode()}");

            // Test CompareTo
            Console.WriteLine("\nTesting CompareTo:");
            students.Sort(); // This will use the CompareTo method internally
            Console.WriteLine("Students sorted by date (default):");
            students.ForEach(student => Console.WriteLine(student.ToString()));

            // Change comparison parameter to id and sort again
            Student.SetCompareParameter("studentID");
            students.Sort();
            Console.WriteLine("\nStudents sorted by studentID:");
            students.ForEach(student => Console.WriteLine(student.ToString()));

            // Change comparison parameter to date and sort again
            Student.SetCompareParameter("date");
            students.Sort();
            Console.WriteLine("\nStudents sorted by dateRegistered:");
            students.ForEach(student => Console.WriteLine(student.ToString()));

            Console.ReadKey();
        }
    }
    
}
