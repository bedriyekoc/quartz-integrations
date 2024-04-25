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
    public class SimpleBackgroundJob : IJob
    {
        private readonly ILogger<SimpleBackgroundJob> _logger;
        public SimpleBackgroundJob(ILogger<SimpleBackgroundJob> logger)
        {
            _logger = logger;

        }
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Simple schedule background job");
            _logger.LogInformation("Job has been working");
            return Task.CompletedTask;
        }
    }
}
