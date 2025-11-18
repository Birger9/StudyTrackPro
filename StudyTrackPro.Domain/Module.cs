using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StudyTrackPro.Domain
{
    public class Module
    {
        public required string name;
        public int order;

        public List<Lesson> lessons = [];

        public void AddLesson(Lesson lesson)
        {
            lessons = [.. lessons, lesson];
        }
    }
}

