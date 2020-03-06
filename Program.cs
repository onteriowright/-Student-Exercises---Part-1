using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises CSharp = new Exercises("learning C#", "C#");
            Exercises DotNet = new Exercises("learning .Net", "C#");
            Exercises Classes = new Exercises("learning Classes", "C#");
            Exercises Methods = new Exercises("learning Methods", "C#");
            Exercises Constructors = new Exercises("learning Constructors", "C#");

            CSharp.Print();
            DotNet.Print();
            Classes.Print();
            Methods.Print();
            Constructors.Print();

            Cohort DayCohort40AndEveningCohort12 = new Cohort(40, 12);
            Cohort DayCohort41AndEveningCohort13 = new Cohort(41, 13);
            Cohort DayCohort42AndEveningCohort14 = new Cohort(42, 14);

            DayCohort40AndEveningCohort12.PrintCohorts();
            DayCohort41AndEveningCohort13.PrintCohorts();
            DayCohort42AndEveningCohort14.PrintCohorts();

        }
    }
}