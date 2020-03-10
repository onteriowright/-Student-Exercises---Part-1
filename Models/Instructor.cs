using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Instructors
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public string TeacherCohort { get; set; }
    public string Speciality { get; set; }

    public void AssignAssignment(Student student, Exercises assignment)
    {
      student.CurrentExercises.Add(assignment);
    }

    public Instructors(string firstName, string lastName, string slackHandle, string teacherChort, string speciality)
    {
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = slackHandle;
      TeacherCohort = teacherChort;
      Speciality = speciality;
    }
  }
}