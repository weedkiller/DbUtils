﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoweredSoft.DbUtils.EF.Generator.SqlServer.EF6.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new SqlServerGenerator();
            g.Options = new SqlServerGeneratorOptions
            {
                OutputDir = @"C:\test",
                OutputSingleFileName = "All.generated.cs",
                Namespace = "Acme.[SCHEMA].Dal",
                ConnectionString = "Server=ps-sql.dev;Database=Acme;user id=acme;password=-acmepw2016-"
            };
            g.Generate();
        }
    }
}
