namespace StudyTrackPro.Domain
{
    public class Course
    {
        public required string title;
        public required string provider;
        public bool isCompleted;

        public required Module[] modules;
    }
}
