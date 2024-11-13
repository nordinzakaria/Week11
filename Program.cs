// See https://aka.ms/new-console-template for more information
using Week11;

Console.WriteLine("Hello, World!");

Job job = new OneTimeJob() { Name = "WashDish", Description = "Use Soap" };

// need special types of jobs
// One Time Job - has a certain fixed start and end date
// Recurring Job - has a certain date (DateTime) when it was last done
// and a certain time interval (TimeSpan) before the next execution

OneTimeJob otjob = new OneTimeJob()
{
    Name = "RepairRoof",
    Description = "Leaks",
    Date = DateTime.Now
};

RecurringJob rjob = new RecurringJob()
{
    Name = "Wash Dish",
    Description = "Kitchen job",
    LastDone = DateTime.Now,
    TimeBeforeNext = new TimeSpan(1, 0, 0)
};



JobList jobList = new JobList();
jobList.Add(job);
jobList.Add(otjob);
jobList.Add(rjob);

jobList.Report();

Account acc = new Account();
acc.Add(rjob);
acc.Add(otjob);
