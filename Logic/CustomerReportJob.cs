using CoreBatch;
using log4net;
using SampleBatch.Dao;

namespace SampleBatch.Logic
{
    public class CustomerReportJob : IBatchJob
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CustomerReportJob));
        private readonly ICustomerDao _dao;

        public CustomerReportJob(ICustomerDao dao)
        {
            _dao = dao;
        }

        public string Name { get { return "CustomerReport"; } }

        public int Execute(string[] args)
        {
            var names = _dao.GetCustomerNames();
            foreach (var n in names)
                Log.InfoFormat("Customer: {0}", n);
            return BatchRunner.ExitSuccess;
        }
    }
}
