﻿using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;

namespace MedicalStore.Data
{
    public class DbMigrationExtension :IDbMigrationExtension
    {
        public  void InitializeDatabase(MedicalStoreContext context)
        {
            if (!context.Database.Exists() || !context.Database.CompatibleWithModel(false))
            {
                var configuration = new DbMigrationsConfiguration();
                var migrator = new DbMigrator(configuration);
                migrator.Configuration.TargetDatabase = new DbConnectionInfo(context.Database.Connection.ConnectionString, "System.Data.SqlClient");
                var migrations = migrator.GetPendingMigrations();
                var migrationsArray = migrations as string[] ?? migrations.ToArray();
                if (migrationsArray.Any())
                {
                    var scriptor = new MigratorScriptingDecorator(migrator);
                    var script = scriptor.ScriptUpdate(null, migrationsArray.Last());

                    if (!string.IsNullOrEmpty(script))
                    {
                        context.Database.ExecuteSqlCommand(script);
                    }
                }
                else throw new ArgumentNullException(nameof(migrations));
            }
        }
        
    }
}