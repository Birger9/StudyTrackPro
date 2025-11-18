using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTrackPro.Domain
{
    public class Module
    {
        public required string name;
        public int order;

        public required Lesson[] lessons;
    }
}

