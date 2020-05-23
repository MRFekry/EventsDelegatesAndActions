using System;

namespace EventsExercise
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
