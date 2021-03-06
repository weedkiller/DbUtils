﻿
using PoweredSoft.DbUtils.EF.Generator.EFCore.SqlServer;
using PoweredSoft.DbUtils.Schema.SqlServer.Extensions;
using System;
using System.Linq;

namespace dev_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var schema = new DatabaseSchema();
            schema.ConnectionString = "server=192.168.100.154;uid=dlebee;pwd=-pssql2016-;database=Acme";
            schema.LoadSchema();*/

            var gen = new DatabaseGenerator();
            gen.InitializeOptionsWithDefault();
            gen.Options.ConnectionString = "Server=ps-sql.dev;Database=Acme;user id=acme;password=-acmepw2016-";
            //gen.Options.ConnectionString = "server=192.168.100.154;uid=dlebee;pwd=-pssql2016-;database=Acme";
            gen.Options.OutputDir = "C:\\test\\output";
            gen.Options.ContextName = "AcmeContext";
            gen.Options.OutputSingleFileName = "All.generated.cs";
            gen.Options.Namespace = "Acme.Dal";
            gen.Options.CleanOutputDir = true;
            gen.Options.ConnectionStringName = "Acme";
            gen.Options.GenerateContextSequenceMethods = true;
            gen.Options.AddConnectionStringOnGenerate = true;
            //gen.Generate();;

            var schema = gen.CreateSchema();
            schema.ConnectionString = gen.Options.ConnectionString;
            schema.LoadSchema();

            var firstSchema = schema.Tables.First().GetTableSchema();
        }
    }
}
