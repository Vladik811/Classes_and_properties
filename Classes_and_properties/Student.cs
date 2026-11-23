using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_properties
{
    public class Student
    {
        string surname;
        string name;
        string patronymic;
        int age;
        int[][] marks = new int[3][];
        
        public Student(string surname, string name, string patronymic, int age, int[][] marks)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.age = age;
            this.marks = marks;
        }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }

        public void get_the_mark(int[][] marks, int subject_i)
        { 
            Console.Write("Enter the mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            marks[subject_i].Append(mark);
        }

        public double get_average_mark(int[][] marks, int subject_i)
        {
            double average = marks[subject_i].Average();
            return average;
        }

        public int max_mark(int[][] marks, int subject_i)
        {
            int max = marks[subject_i].Max();
            return max;
        }
        public int min_mark(int[][] marks, int subject_i)
        {
            int min = marks[subject_i].Min();
            return min;
        }
        public string print_marks(int[][] marks)
        {
            StringBuilder str = new StringBuilder { };
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = 0; j < marks[i].Length; j++)
                {
                    str.Append(marks[i][j]);
                    str.Append(' ');
                }
                str.Append("\n");
            }
            return str.ToString();
        }
        public override string ToString()
        {
            return $"Marks: {print_marks(marks)}\nAverage: {get_average_mark(marks, 0)}\nMax mark: {max_mark(marks, 0)}\nMin mark: {min_mark(marks, 0)}";
        }
    }
}
