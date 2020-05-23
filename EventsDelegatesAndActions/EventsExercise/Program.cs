using System;

namespace EventsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            worker.WorkPerformed += Work_WorkPerformed;
            worker.WorkCompleted += Work_WorkCompeleted;

            worker.DoWork(10, WorkType.GenerateReports);

            Console.Read();
        }

        static void Work_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
        }

        static void Work_WorkCompeleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }
    }
}
