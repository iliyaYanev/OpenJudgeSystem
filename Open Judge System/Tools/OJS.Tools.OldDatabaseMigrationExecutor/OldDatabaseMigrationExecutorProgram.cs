﻿namespace OJS.Tools.OldDatabaseMigrationExecutor
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using OJS.Data;
    using OJS.Tools.OldDatabaseMigration;

    internal class OldDatabaseMigrationExecutorProgram
    {
        internal static void Main()
        {
            Console.WriteLine("Starting migration...");
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OjsDbContext, OldDatabaseMigrationConfiguration>());
            var context = new OjsDbContext();
            var problemsCount = context.Problems.Count();
            Console.WriteLine("Done!");
        }
    }
}
