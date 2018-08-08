﻿using System.Data.Common;
using System.Threading.Tasks;

namespace Sumo.Data
{
    public class CommandProcedure : Procedure, ICommandProcedure
    {
        public CommandProcedure(DbConnection dbConnection, IParameterFactory parameterFactory) : base(dbConnection, parameterFactory) { }

        public CommandProcedure(IDataProviderFactory factory) : base(factory) { }

        public long Execute<P>(P procedureParams, DbTransaction dbTransaction = null) where P : class
        {
            SetParameterValues(procedureParams);
            if (_command.Transaction != dbTransaction) _command.Transaction = dbTransaction;
            _command.ExecuteNonQuery();
            FillOutputParameters(procedureParams);
            return GetProcedureResult();
        }

        public async Task<long> ExecuteAsync<P>(P procedureParams, DbTransaction dbTransaction = null) where P : class
        {
            return await Task.Run(async () =>
            {
                SetParameterValues(procedureParams);
                if (_command.Transaction != dbTransaction) _command.Transaction = dbTransaction;
                await _command.ExecuteNonQueryAsync();
                FillOutputParameters(procedureParams);
                return GetProcedureResult();
            });
        }
    }
}
