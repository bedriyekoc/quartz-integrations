using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzInfrastructure.Jobs
{
    [DisallowConcurrentExecution]
    public class CronBackgroundJob : IJob
    {
        private readonly ILogger<CronBackgroundJob> _logger;
        public CronBackgroundJob(ILogger<CronBackgroundJob> logger)
        {
            _logger = logger;

        }
        public Task Execute(IJobExecutionContext context)
        {
            //you can implement your background tasks
            Console.WriteLine("this job is working  with cron schedule");
            _logger.LogInformation("Job has been working");
            return Task.CompletedTask;
        }
    }
}
