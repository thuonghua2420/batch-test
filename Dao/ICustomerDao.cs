using System.Collections.Generic;

namespace SampleBatch.Dao
{
    public interface ICustomerDao
    {
        IList<string> GetCustomerNames();
    }
}
