﻿using PoweredSoft.DbUtils.Schema.Core;

namespace PoweredSoft.DbUtils.Schema.MySql
{
    public class Sequence : ISequence
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public object StartAt { get; set; }
        public object IncrementsBy { get; set; }
        public object MaxValue { get; set; }
        public IDatabaseSchema DatabaseSchema => MySqlDatabaseSchema;
        public DatabaseSchema MySqlDatabaseSchema { get; set; }
        public int? NumericPrecision { get; set; }
        public int? NumericScale { get; set; }
        public object MinValue { get; set; }
        public bool IsUnsigned => false;
    }
}
