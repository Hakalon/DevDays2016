using DevDays2016.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDays2016.Models
{
    public class CustomInitializer : IDatabaseInitializer<PostContext>
    {
        public void InitializeDatabase(PostContext context)
        {
            if (!context.Database.Exists() || !context.Database.CompatibleWithModel(false))
            {
                var configuration = new Configuration();
                var migrator = new DbMigrator(configuration);
                migrator.Configuration.TargetDatabase = new DbConnectionInfo(context.Database.Connection.ConnectionString, "System.Data.SqlClient");
                var migrations = migrator.GetPendingMigrations();
                if (migrations.Any())
                {
                    var scriptor = new MigratorScriptingDecorator(migrator);
                    string script = scriptor.ScriptUpdate(null, migrations.Last());
                    if (!String.IsNullOrEmpty(script))
                    {
                        context.Database.ExecuteSqlCommand(script);
                    }
                }
            }
        }

    }
}
