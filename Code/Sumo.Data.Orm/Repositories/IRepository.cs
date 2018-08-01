﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sumo.Data.Orm.Repositories
{
    public interface IRepository
    {
        void Write<T>(T entity, bool autoCreateTable = true) where T : class;
        Task WriteAsync<T>(T entity, bool autoCreateTable = true) where T : class;

        void Write<T>(T[] entities, bool autoCreateTable = true) where T : class;
        Task WriteAsync<T>(T[] entities, bool autoCreateTable = true) where T : class;

        T Read<T>(object searchKey) where T : class;
        Task<T> ReadAsync<T>(object searchKey) where T : class;

        T[] Read<T>(Dictionary<string, object> parameters) where T : class;
        Task<T[]> ReadAsync<T>(Dictionary<string, object> parameters) where T : class;
    }
}


