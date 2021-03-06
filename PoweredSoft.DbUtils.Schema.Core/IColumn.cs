﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoweredSoft.DbUtils.Schema.Core
{
    public interface IColumnWithDateTimePrecision : IColumn
    {
        int? DateTimePrecision { get; }
    }

    public interface IColumn : IHasDataType
    {
        string Name { get; }
        string DefaultValue { get; }
        int? CharacterMaximumLength { get; }
        bool IsAutoIncrement { get; }
        bool IsPrimaryKey { get; }
        int PrimaryKeyOrder { get; }
        bool IsForeignKey { get; }
        bool IsNullable { get; }
        ITable Table { get; }
        bool IsUnsigned { get; }
    }
}
