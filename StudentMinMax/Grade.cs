using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentMinMax
{
    class Grade
    {
        //create a list of integers where we'll store the user's grades
        //also create integers where we'll store the user's minimum and maximum grades
        public List<int> Grades { get; set; }
        public int MinGrade { get; set; }
        public int MaxGrade { get; set; }

        //create a method where we'll find the user's grades
        //we do this by using the ReadData() method from the Student class to read a line of data
        //from the .txt file
        public List<int> FindGrades(string studentdata)
        {
            //then we separate the name from the numbers by re-defining the string as
            //only whatever characters are after the first blank space
            studentdata = studentdata.Substring(studentdata.IndexOf(' ') + 1);
            //then we separate each number, separated by blank spaces, into an item on a list
            List<int> grades = new List<int>(Array.ConvertAll(studentdata.Split(' '), int.Parse));
            Grades = grades;
            //then we return the list
            return Grades;
        }

        //find and return the user's minimum grade
        public int FindMinGrade()
        {
            //loop through the list of the user's grades
            for (int i = 0; i < (Grades.Count - 1); i++)
            {
                //if the current grade is less than the next grade, remove it
                //otherwise, do nothing
                if (Grades[i] >= Grades[i + 1])
                {
                    Grades.RemoveAt(i);
                    i--;
                }
                else
                {
                    Grades.RemoveAt(i + 1);
                    i--;
                }
            }

            int temp = Convert.ToInt32(Grades.Average());

            return temp;
        }

        //find and return the user's maximum grade
        public int FindMaxGrade()
        {
            //loop through the list of the user's grades
            for (int i = 0; i < (Grades.Count - 1 ); i++)
            {
                //if the current grade is more than the next grade, remove it
                //otherwise, do nothing
                if (Grades[i] <= Grades[i + 1])
                {
                    Grades.RemoveAt(i);
                    i--;
                }
                else
                {
                    Grades.RemoveAt(i + 1);
                    i--;
                }
            }
            int temp = Convert.ToInt32(Grades.Average());

            return temp;
        }
    }
}
