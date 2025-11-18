using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StudyTrackPro.Domain
{
    public class Lesson
    {
        public required string title;
        public int estimatedMinutes;
        public bool isCompleted;

        public void MarkCompleted()
        {
            isCompleted = true;
        }
    }
}

