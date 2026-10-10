using System.Collections.Generic;
using CoreBatch.Test;
using NUnit.Framework;
using SampleBatch.Dao;
using SampleBatch.Logic;

namespace SampleBatch.Test
{
    [TestFixture]
    public class CustomerReportJobTests : BatchTestBase
    {
        private sealed class StubDao : ICustomerDao
        {
            public IList<string> GetCustomerNames() { return new List<string> { "X" }; }
        }

        [Test]
        public void Execute_WithStubDao_Succeeds()
        {
            AssertSuccess(new CustomerReportJob(new StubDao()));
        }

        [Test]
        public void Execute_WithRealDao_Succeeds()
        {
            AssertSuccess(new CustomerReportJob(new CustomerDao()));
        }
    }
}
