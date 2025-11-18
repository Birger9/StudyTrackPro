using StudyTrackPro.Domain;
using System;

namespace StudyTrackPro.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Temporary testing area for Milestone 1
            System.Console.WriteLine("=== StudyTrack Pro ===");

            // Create a course
            Course course = new()
            {
                title = "C# Mastery",
                provider = "Udemy"
            };

            // Create a module
            Module module1 = new()
            {
                name = "Basics",
                order = 1
            };

            // Create lessons
            Lesson l1 = new()
            {
                title = "Variables",
                estimatedMinutes = 10
            };

            Lesson l2 = new()
            {
                title = "Loops",
                estimatedMinutes = 15
            };

            // Add lessons to module
            module1.AddLesson(l1);
            module1.AddLesson(l2);

            // Add module to course
            course.AddModule(module1);

            // Mark lesson 1 as completed
            l1.MarkCompleted();

            // Print summary
            course.PrintSummary();
        }
    }
}