using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMinMax
{
    class Logic
    {
        public void Run()
        {
            //create an instance of the Student class
            Student student = new Student();

            //create an instance of the Grade class
            Grade grade = new Grade();

            //read a line of data in the .txt file and assign the value of the data to student.StudentData
            student.StudentData = student.ReadData();

            //store the value of student.StudentData in another few strings
            //this is so that we can use the data we read using the streamreader
            //not just to find the student's name, but also to find their min/max grades
            student.StudentName = student.StudentData;
            student.StudentGrade = student.StudentData;
            student.StudentGrade2 = student.StudentData;

            while (student.StudentData != null)
            {
                //assign a value to student.StudentName by removing all numbers from the line of data
                //this should end up as being the student's name
                student.StudentName = student.FindStudentName();
                //write the student's name
                Console.Write(student.StudentName + " ");
                //assign a value to grade.Grades by removing the name
                //and separating the numbers into a list
                //we use the string temp because the string student.StudentData has already had the
                //numbers removed from it
                grade.Grades = grade.FindGrades(student.StudentGrade);
                student.StudentMin = grade.FindMinGrade();
                Console.Write(student.StudentMin + " ");
                grade.Grades = grade.FindGrades(student.StudentGrade2);
                student.StudentMax = grade.FindMaxGrade();
                Console.WriteLine(student.StudentMax + " ");

                //read a line of data in the .txt file and assign the value of the data to student.StudentData
                //we'll repeat this for each new student whose data we want to read
                student.StudentData = student.ReadData();
                //assign a value to the temporary strings like before
                student.StudentGrade = student.StudentData;
                student.StudentGrade2 = student.StudentData;
            }
        }
    }
}
