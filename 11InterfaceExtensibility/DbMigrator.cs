using System;

namespace InterfaceExtensibility
{
    internal class DbMigrator
    {
        private ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migrating started at {DateTime.Now}");

            //Implementation

            _logger.LogInfo($"Migrating started at {DateTime.Now}");
        }

    }
}