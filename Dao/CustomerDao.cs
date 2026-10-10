using System.Collections.Generic;
using log4net;

namespace SampleBatch.Dao
{
    /// <summary>Dao mau: tra du lieu in-memory thay cho DB that.</summary>
    public class CustomerDao : ICustomerDao
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CustomerDao));

        public IList<string> GetCustomerNames()
        {
            Log.Debug("Loading customers");
            return new List<string> { "Alice", "Bob", "Carol" };
        }
    }
}
