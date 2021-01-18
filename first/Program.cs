using System;

namespace first
{

    class Course
    {
        public string courseName;
        public string instructor;
        public string completionRate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.courseName = "C#";
            course1.instructor = "Tamer Murtazaoğlu";
            course1.completionRate = "48";

            Course course2 = new Course();
            course2.courseName = "JavaScript";
            course2.instructor = "Tamer Murtazaoğlu";
            course2.completionRate = "23";

            Course course3 = new Course();
            course3.courseName = "Java";
            course3.instructor = "Tamer Murtazaoğlu";
            course3.completionRate = "15";

            Course[] courses = new Course[] { course1, course2, course3 };
            foreach (Course course in courses)
            {
                Console.WriteLine("Course name: " + course.courseName);
                Console.WriteLine("Completion rate: " + course.completionRate);
                Console.WriteLine("Instructor: " + course.instructor);
                Console.WriteLine("\n");
            }

        }
    }
}
