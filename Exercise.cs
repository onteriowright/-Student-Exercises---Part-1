using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Exercises
  {
    public string NameOfExercise { get; set; }
    public string LanguageOfExercise { get; set; }

    public List<Exercises> ListOfExercises { get; set; } = new List<Exercises>();

    public Exercises(string nameOfExercise, string languageOfExercise)
    {
      NameOfExercise = nameOfExercise;
      LanguageOfExercise = languageOfExercise;
    }
    public void addExercise(Exercises exercise)
    {
      ListOfExercises.Add(exercise);
    }
    public Exercises()
    {
      Console.WriteLine("Printing list of exercises: ▶▶▶▶▶");
      Console.WriteLine();
    }
    public void Print()
    {
      foreach (Exercises exercise in ListOfExercises)
      {
        Console.WriteLine($"We are learning {exercise.NameOfExercise} and it's written in {exercise.LanguageOfExercise}");
        Console.WriteLine();
      }
    }
  }
}