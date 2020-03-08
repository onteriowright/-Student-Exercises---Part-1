using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Cohort
  {
    public string CohortName { get; set; }
    public List<Student> ListOfStudents { get; set; } = new List<Student>();
    public List<Instructors> ListOfInstructors { get; set; } = new List<Instructors>();
    public List<Cohort> ListOfCohorts { get; set; } = new List<Cohort>();
    public void addCohort(Cohort cohort)
    {
      ListOfCohorts.Add(cohort);
    }
    public Cohort(string cohort)
    {
      CohortName = cohort;
    }
    public void addStudents(Student student)
    {
      ListOfStudents.Add(student);
    }
    public void addInstructor(Instructors instructor)
    {
      ListOfInstructors.Add(instructor);
    }
    public void PrintCohorts()
    {
      foreach (Cohort cohorts in ListOfCohorts)
      {
        Console.WriteLine($"Please welcome Day Cohort {cohorts.CohortName}");
        Console.WriteLine();
      }
    }
  }
}