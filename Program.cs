using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises CSharp = new Exercises("C#", "C#");
            Exercises DotNet = new Exercises(".Net", "C#");
            Exercises Classes = new Exercises("Classes", "C#");
            Exercises Methods = new Exercises("Methods", "C#");
            Exercises Constructors = new Exercises("Constructors", "C#");

            var DayCohort37 = new Cohort("Day Cohort 37");
            var DayCohort38 = new Cohort("Day Cohort 38");
            var DayCohort39 = new Cohort("Day Cohort 39");

            var Onterio = new Student()
            {
                FirstName = "Onterio",
                LastName = "Wright",
                SlackHandle = "onteriowright",
                StudentCohort = "Day Cohort 37",
                Gender = "male"
            };

            var Akemo = new Student()
            {
                FirstName = "Akemo",
                LastName = "Wright",
                SlackHandle = "akemowright",
                StudentCohort = "Day Cohort 39",
                Gender = "male"
            };

            var Danyeal = new Student()
            {
                FirstName = "Danyeal",
                LastName = "Wright",
                SlackHandle = "danyealwright",
                StudentCohort = "Day Cohort 39",
                Gender = "female"
            };

            var Mo = new Instructors("Mo", "Silva", "Mo Time", "Cohort 39", "cheese cake");
            var Steve = new Instructors("Steve", "Brownee", "Cohortle", "Cohort 39", "teaching");
            var Rose = new Instructors("Rose", "Wisotzky", "Roses", "Cohort 37", "Art");

            Rose.AssignAssignment(Onterio, CSharp);
            Steve.AssignAssignment(Akemo, DotNet);
            Mo.AssignAssignment(Danyeal, Classes);

            DayCohort37.addInstructor(Rose);
            DayCohort39.addInstructor(Steve);
            DayCohort39.addInstructor(Mo);

            DayCohort37.addStudents(Onterio);
            DayCohort39.addStudents(Danyeal);
            DayCohort39.addStudents(Akemo);

            var Student = new Student();

            Student.addStudent(Onterio);
            Student.addStudent(Akemo);
            Student.addStudent(Danyeal);
            Student.PrintStudents();

            Console.WriteLine($"They're {Student.ListOfStudents.Count} students!");
            Console.WriteLine();

            var Exercises = new Exercises();

            Exercises.addExercise(CSharp);
            Exercises.addExercise(DotNet);
            Exercises.addExercise(Classes);
            Exercises.addExercise(Methods);
            Exercises.addExercise(Constructors);
            Exercises.Print();

            DayCohort37.addCohort(DayCohort37);
            DayCohort38.addCohort(DayCohort38);
            DayCohort39.addCohort(DayCohort39);

            Console.WriteLine($"Printing Cohorts 🖨🖨🖨🖨🖨");
            Console.WriteLine();
            DayCohort37.PrintCohorts();
            DayCohort38.PrintCohorts();
            DayCohort39.PrintCohorts();

            foreach (Exercises exercise in Exercises.ListOfExercises)
            {
                Console.WriteLine($"↪↪↪↪↪↪{exercise.NameOfExercise}↩↩↩↩↩↩");
                foreach (Student student in Student.ListOfStudents)
                {
                    foreach (Exercises singleExercise in student.CurrentExercises)
                    {
                        if (singleExercise.NameOfExercise == exercise.NameOfExercise)
                        {
                            Console.WriteLine($"💻💻💻💻💻💻{student.FirstName} {student.LastName}💻💻💻💻💻");
                            Console.WriteLine();
                        }
                    }
                }

            }

        }
    }
}