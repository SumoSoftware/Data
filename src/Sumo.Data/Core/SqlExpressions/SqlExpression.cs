﻿using Sumo.Data.Expressions;
using System;
using System.Text;

namespace Sumo.Data.SqlExpressions
{
    public sealed class SqlExpression 
    {
        public SqlExpression(IFromTable table, IExpression expression)
        {
            Table = table ?? throw new ArgumentNullException(nameof(table));
            Expression = expression ?? throw new ArgumentNullException(nameof(expression));
        }

        public IFromTable Table { get; }
        public IExpression Expression { get; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append(Table);
            builder.Append(Expression);

            return builder.ToString();
        }
    }
}
