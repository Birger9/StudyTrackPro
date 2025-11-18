using StudyTrackPro.Domain;
using System;

namespace StudyTrackPro.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Temporary testing area for Milestone 1
            System.Console.WriteLine("StudyTrack Pro starting...");

            // Create lessons
            var lesson1 = new Lesson
            {
                title = "Introduction to C#",
                estimatedMinutes = 20,
                isCompleted = false
            };

            var lesson2 = new Lesson
            {
                title = "Classes & Objects",
                estimatedMinutes = 35,
                isCompleted = false
            };

            var lesson3 = new Lesson
            {
                title = "Collections and LINQ",
                estimatedMinutes = 40,
                isCompleted = true
            };

            // Create modules
            var module1 = new Module
            {
                name = "Getting Started",
                order = 1,
                lessons = [lesson1, lesson2]
            };

            var module2 = new Module
            {
                name = "Intermediate Topics",
                order = 2,
                lessons = [lesson3]
            };

            // Create course
            var course = new Course
            {
                title = "C# Fundamentals",
                provider = "StudyTrack Pro",
                modules = [module1, module2],
                isCompleted = false
            };

            // Print course info to verify everything works
            PrintCourseSummary(course);
        }

        private static void PrintCourseSummary(Course course)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Course: {course.title}");
            System.Console.WriteLine($"Provider: {course.provider}");
            System.Console.WriteLine($"Modules: {course.modules.Length}");

            var courseStatus = course.isCompleted ? "Completed" : "Not completed";
            System.Console.WriteLine(courseStatus);
            System.Console.WriteLine(new string('-', 40));

            foreach (var module in course.modules)
            {
                System.Console.WriteLine($"Module {module.order}: {module.name} (Lessons: {module.lessons.Length})");
                foreach (var lesson in module.lessons)
                {
                    var status = lesson.isCompleted ? "Completed" : "Not completed";
                    System.Console.WriteLine($"  - {lesson.title} [{lesson.estimatedMinutes} min] - {status}");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine(new string('-', 40));
            System.Console.WriteLine("End of course summary.");
        }
    }
}