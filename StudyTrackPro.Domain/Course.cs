namespace StudyTrackPro.Domain
{
    public class Course
    {
        public required string title;
        public required string provider;
        public bool isCompleted;

        public List<Module> modules = [];

        public void AddModule(Module module)
        {
           modules = [.. modules, module];
        }

        public void PrintSummary()
        {
            Console.WriteLine($"Course: {title} by {provider}");
            string courseStatus = isCompleted ? "Completed" : "Not completed";
            Console.WriteLine($"Status: {courseStatus}");


            Console.WriteLine("Modules:");
            foreach (var module in modules)
            {
                Console.WriteLine($"Module {module.order}: {module.name} (Lessons: {module.lessons.Count})");
                foreach (var lesson in module.lessons)
                {
                    var status = lesson.isCompleted ? "Completed" : "Not completed";
                    Console.WriteLine($"  - {lesson.title} [{lesson.estimatedMinutes} min] - {status}");
                }
                Console.WriteLine();
            }
        }
    }
}
