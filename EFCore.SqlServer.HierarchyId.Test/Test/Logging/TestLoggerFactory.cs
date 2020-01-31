using Microsoft.Extensions.Logging;

namespace Bricelam.EntityFrameworkCore.Test.Logging
{
    class TestLoggerFactory : ILoggerFactory
    {
        public TestLogger Logger { get; }
            = new TestLogger();

        public void AddProvider(ILoggerProvider provider)
        {
            // do nothing
        }

        public ILogger CreateLogger(string categoryName)
            => Logger;

        public void Dispose()
        {
        }
    }
}
