using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Student
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string SlackHandle { get; set; }
    public string StudentCohort { get; set; }
    public List<Student> ListOfStudents { get; set; } = new List<Student>();
    public List<Exercises> CurrentExercises { get; set; } = new List<Exercises>();
    public void addStudent(Student student)
    {
      ListOfStudents.Add(student);
    }

    public void PrintStudents()
    {
      foreach (Student student in ListOfStudents)
      {
        if (student.Gender == "male")
        {
          Console.WriteLine($"{student.FirstName} {student.LastName} is Currently in {student.StudentCohort}. His slack handle is: {student.SlackHandle}");
          Console.WriteLine();
        }
        else if (student.Gender == "female")
        {
          Console.WriteLine($"{student.FirstName} {student.LastName} is Currently in {student.StudentCohort}. Her slack handle is: {student.SlackHandle}");
          Console.WriteLine();
        }

      }

    }
  }
}