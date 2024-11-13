using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    // Joblist manages a list of Jobs
    // it has the following operations:
    // add a new jib, report on all the jobs
    internal class JobList
    {
        List<Job> jobs = new List<Job>();

        public void Add(Job job)
            { jobs.Add(job); }

        public void Report()
        {
            foreach (Job job in jobs)
            {
                job.Report();
            }
        }
    }
}
