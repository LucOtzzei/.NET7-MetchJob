using Otzzei.MetchJob.Infrastructure.Context;
using Xunit;

namespace Otzzei.MetchJob.Tests
{
    public class DatabaseConnectionTest
    {
        [Fact]
        public void TestDatabaseConnection()
        {
            var context = new MetchJobContext();
            bool connected;

            try { connected = context.Database.CanConnect(); }
            catch (Exception ex) { throw new Exception("Unable to connect to the database"); }

            Assert.True(connected);
        }
    }
}
