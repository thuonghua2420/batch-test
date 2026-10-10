using CoreBatch;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using SampleBatch.Dao;
using SampleBatch.Logic;

namespace SampleBatch.Main
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            BasicConfigurator.Configure(new ConsoleAppender { Layout = new PatternLayout("%date %-5level %message%newline") });
            return BatchRunner.Run(new CustomerReportJob(new CustomerDao()), args);
        }
    }
}
