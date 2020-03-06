using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Instructors
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public int TeacherCohort { get; set; }
    public string Speciality { get; set; }
    public List<Exercises> TeacherAssignExercises = new List<Exercises>();

    public void AssignAssignment(Exercises assignment)
    {
      TeacherAssignExercises.Add(assignment);
    }
  }
}