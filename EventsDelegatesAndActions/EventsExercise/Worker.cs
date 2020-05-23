using System;
using System.Threading;

namespace EventsExercise
{
    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 1; i <= hours; i++)
            {
                Thread.Sleep(1000);
                OnWorkPerformed(i, workType);
            }
            OnWorkCompleted();
        }

        protected void OnWorkPerformed(int hours, WorkType workType)
        {
            WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(hours, workType));
        }

        protected void OnWorkCompleted()
        {
            WorkCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
