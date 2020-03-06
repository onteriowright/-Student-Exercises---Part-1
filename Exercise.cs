using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Exercises
  {
    public string NameOfExercise { get; set; }
    public string LanguageOfExercise { get; set; }

    public Exercises(string nameOfExercise, string languageOfExercise)
    {
      NameOfExercise = nameOfExercise;
      LanguageOfExercise = languageOfExercise;
    }
    public void Print()
    {
      Console.WriteLine($"What are {NameOfExercise} and it's written in {LanguageOfExercise}");
      Console.WriteLine("========================================================================");

    }
  }
}