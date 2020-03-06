using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Cohort
  {
    public int DayCohort { get; set; }
    public int EveningCohort { get; set; }
    public List<Student> ListOfStudents = new List<Student>();
    public List<Instructors> ListOfInstructors = new List<Instructors>();

    public Cohort(int dayCohort, int eveningCohort)
    {
      DayCohort = dayCohort;
      EveningCohort = eveningCohort;
    }

    public void PrintCohorts()
    {
      Console.WriteLine($"Please welcome Day Cohort {DayCohort} and Evening Cohort {EveningCohort}!");
      Console.WriteLine("========================================================================");
    }
  }
}