using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsTask
{
    class CourseSubject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }

    class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        private List<CourseSubject> _subjects = new List<CourseSubject>();

        public List<CourseSubject> Subjects
        {
            get
            {
                return _subjects;
            }
        }
        public void AddSubjects(CourseSubject subject)
        {
            _subjects.Add(subject);
        }
        public void AddSubjects(List<CourseSubject> subjects)
        {
            _subjects.AddRange(subjects);
        }

        public void RemoveSubjects(CourseSubject subject)
        {
            _subjects.Remove(subject);
        }
    }

    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Course> Courses;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<CourseSubject> subjectsList = new List<CourseSubject>();
            List<Course> coursesList = new List<Course>();
            List<Student> studentsList = new List<Student>();

            bool endProcess = false;
            do
            {
                Console.WriteLine("\nEnter a option-\n");
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Add Student");
                Console.WriteLine("4. View All Subject");
                Console.WriteLine("5. View All Courses");
                Console.WriteLine("6. View All Students");
                Console.WriteLine("7. Find Subject by Name/Code");
                Console.WriteLine("8. Find Course by Name/Code");
                Console.WriteLine("9. Find Student by Name/Code");
                Console.WriteLine("10. Exit\n");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        bool endProcessOfAdding = false;
                        do
                        {
                            Console.Write("\nEnter Subject Id : ");
                            string subId = Console.ReadLine();
                            Console.Write("Enter Subject Name : ");
                            string subName = Console.ReadLine();
                            Console.Write("Enter Subject Code : ");
                            string subCode = Console.ReadLine();

                            CourseSubject newSubject = new CourseSubject();
                            newSubject.Id = subId;
                            newSubject.Name = subName;
                            newSubject.Code = subCode;

                            subjectsList.Add(newSubject);

                            Console.WriteLine("\nSubject added successfully!");
                            Console.WriteLine("\nDo you want to Add More Subjects (Y/N) : ");
                            string AddOption = Console.ReadLine();

                            switch (AddOption)
                            {
                                case "Y":
                                    continue;
                                case "y":
                                    continue;
                                case "N":
                                    endProcessOfAdding = true;
                                    break;
                                case "n":
                                    endProcessOfAdding = true;
                                    break;

                                default:
                                    Console.WriteLine("\nInvalid option, Please try again\n");
                                    break;
                            }

                        } while (!endProcessOfAdding);

                        break;


                    case "2":
                        bool endProcessOfCourse = false;
                        do
                        {
                            Console.Write("\nEnter Course Id : ");
                            string courseId = Console.ReadLine();
                            Console.Write("Enter Course Name : ");
                            string courseName = Console.ReadLine();
                            Console.Write("Enter Course Code : ");
                            string courseCode = Console.ReadLine();

                            Course newCourse = new Course();
                            newCourse.Id = courseId;
                            newCourse.Name = courseName;
                            newCourse.Code = courseCode;

                            //CourseSubject defaultSubject = subjectsList.FirstOrDefault(s => s.Name == "English");
                            //if (defaultSubject != null)
                            //{
                            //    newCourse.AddSubjects(defaultSubject);
                            //}
                            CourseSubject defaultSubject = new CourseSubject();
                            defaultSubject.Id = "101";
                            defaultSubject.Name = "English";
                            defaultSubject.Code = "ENG";

                            newCourse.AddSubjects(defaultSubject);

                            coursesList.Add(newCourse);

                            Console.WriteLine("\nCourse added successfully!");
                            Console.WriteLine("\nDo you want to Add More Courses (Y/N) : ");
                            string AddOption = Console.ReadLine();
                            switch (AddOption)
                            {
                                case "Y":
                                    continue;
                                case "y":
                                    continue;
                                case "N":
                                    endProcessOfCourse = true;
                                    break;
                                case "n":
                                    endProcessOfCourse = true;
                                    break;

                                default:
                                    Console.WriteLine("\nInvalid option, Please try again\n");
                                    break;
                            }

                        } while (!endProcessOfCourse);

                        break;


                    case "3":
                        bool endProcessOfAddingStudent = false;
                        do
                        {
                            Console.Write("\nEnter Student Id : ");
                            string stId = Console.ReadLine();
                            Console.Write("Enter Student Name : ");
                            string stName = Console.ReadLine();
                            Console.Write("Enter Student Code : ");
                            string stCode = Console.ReadLine();

                            Course defaultCourse = new Course();
                            defaultCourse.Id = "15";
                            defaultCourse.Name = "B.Tech";
                            defaultCourse.Code = "BT";

                            Student newStudent = new Student();
                            newStudent.Id = stId;
                            newStudent.Name = stName;
                            newStudent.Code = stCode;

                            studentsList.Add(newStudent);
                            // newStudent.Courses.Add(defaultCourse);

                            Console.WriteLine("Student added successfully!");
                            Console.WriteLine("\nDo you want to Add More Students (Y/N) : ");
                            string AddOption = Console.ReadLine();
                            switch (AddOption)
                            {
                                case "Y":
                                    continue;
                                case "y":
                                    continue;
                                case "N":
                                    endProcessOfAddingStudent = true;
                                    break;
                                case "n":
                                    endProcessOfAddingStudent = true;
                                    break;

                                default:
                                    Console.WriteLine("\nInvalid option, Please try again\n");
                                    break;
                            }
                        } while (!endProcessOfAddingStudent);

                        break;

                    case "4":
                        Console.WriteLine("All Subjects : ");
                        foreach (var item in subjectsList)
                        {
                            Console.WriteLine("{0}, {1}, {2}", item.Id, item.Name, item.Code);
                        }
                        break;

                    case "5":
                        Console.WriteLine("All Courses : ");
                        foreach (var item in coursesList)
                        {
                            Console.WriteLine("{0}, {1}, {2}", item.Id, item.Name, item.Code);
                        }
                        break;

                    case "6":
                        Console.WriteLine("All Students : ");
                        foreach (var item in studentsList)
                        {
                            Console.WriteLine("{0}, {1}, {2}", item.Id, item.Name, item.Code);
                        }
                        break;

                    case "7":
                        Console.Write("Enter Subject Name or Code: ");
                        string inputSubject = Console.ReadLine().ToLower();

                        CourseSubject foundSubject = subjectsList.FirstOrDefault(
                            s => s.Name.ToLower() == inputSubject || s.Code.ToLower() == inputSubject);

                        if (foundSubject != null)
                        {
                            Console.WriteLine("Subject found: {0}, {1}, {2}", foundSubject.Id, foundSubject.Name, foundSubject.Code);
                        }
                        else
                        {
                            Console.WriteLine("Subject not found.");
                        }
                        break;

                    case "8":
                        Console.Write("Enter Course Name or Code: ");
                        string inputCourse = Console.ReadLine().ToLower();

                        Course foundCourse = coursesList.FirstOrDefault(
                            c => c.Name.ToLower() == inputCourse || c.Code.ToLower() == inputCourse);

                        if (foundCourse != null)
                        {
                            Console.WriteLine("Course found: {0}, {1}, {2}", foundCourse.Id, foundCourse.Name, foundCourse.Code);
                        }
                        else
                        {
                            Console.WriteLine("Course not found.");
                        }
                        break;

                    case "9":
                        Console.Write("Enter Course Name or Code: ");
                        string inputStudent = Console.ReadLine().ToLower();

                        Student foundStudent = studentsList.FirstOrDefault(
                            s => s.Name.ToLower() == inputStudent || s.Code.ToLower() == inputStudent);

                        if (foundStudent != null)
                        {
                            Console.WriteLine("Course found: {0}, {1}, {2}", foundStudent.Id, foundStudent.Name, foundStudent.Code);
                        }
                        else
                        {
                            Console.WriteLine("Course not found.");
                        }
                        break;

                    case "10":
                        Console.WriteLine("\n\nThank You................");
                        endProcess = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid option, Please try again\n");
                        break;
                }
            } while (!endProcess);

            Console.ReadKey();
        }
    }
}