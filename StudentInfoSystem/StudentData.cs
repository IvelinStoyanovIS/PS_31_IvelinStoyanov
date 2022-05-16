using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem.TestData

{
    static public class StudentData
    {

        static public List<Student> TestStudents { 
            get
            {
                ResetTestStudentData();
                return _testStudents;
            } 
            set { }
        }
        
        static private List<Student> _testStudents;

        static private void ResetTestStudentData()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>
                {
                    new Student
                    {
                        Name = "Ivelin",
                        SecondName = "Svetlozarov",
                        LastName = "Stoyanov",
                        Faculty = "FCST",
                        Speciality = "CSE",
                        EducationalQualificationDegree = "Bachelor",
                        StudentStatus = "Редовен",
                        FacultyNumber = "121219032",
                        Course = 3,
                        Stream = 9,
                        Group = 31,
                    },
                    new Student
                    {
                        Name = "Petur",
                        SecondName = "Ivanov",
                        LastName = "Ivanov",
                        Faculty = "FCST",
                        Speciality = "CSE",
                        EducationalQualificationDegree = "Bachelor",
                        StudentStatus = "Редовен",
                        FacultyNumber = "121211032",
                        Course = 3,
                        Stream = 9,
                        Group = 31,
                    },
                    new Student
                    {   Name = "Ivanka",
                        SecondName = "Petkova",
                        LastName = "Karaivanova",
                        Faculty = "FCST",
                        Speciality = "CSE",
                        EducationalQualificationDegree = "Bachelor",
                        StudentStatus = "Редовен",
                        FacultyNumber = "121222032",
                        Course = 3,
                        Stream = 9,
                        Group = 31,
                    },
                };
            }
        }
    }
}

