using System;
using System.Collections;

namespace HashTableChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();


            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(5, "Maria", 98);
            students[2] = new Student(6, "Anton", 65);
            students[3] = new Student(1, "Rebeka", 78);
            students[4] = new Student(4, "Tomas", 87);

            foreach (Student s in students)
            {
                if (!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id,s);
                    Console.WriteLine("Student with ID {0} was add",s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry student with the same ID already exist {0}", s.Id);
                }

            }
        }
    }
    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student (int id, string name, float GPA)
        {
            Id = id;
            Name = name;
            GPA = GPA;
        }
    }
}
