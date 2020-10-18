using Marvel.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Marvel.Services.Common.Base
{
    public class DataContainerBase<T> : IDataContainerArrayList<T>
        where T : class, IDataObject, new()
    {
        public int? Offset { get; private set; }

        public int? Limit { get; private set; }

        public int? Total { get; private set; }

        public int? Count { get; private set; }

        public ICollection<T> Results { get; private set; }

        public DataContainerBase(IQueryable<T> unpaginatedResult, int pageAmount, int skip = 0)
        {
            Offset = skip;
            Total = unpaginatedResult.Count();
            Limit = pageAmount <= 0 ? Total : pageAmount;
            Results = unpaginatedResult.Skip(Offset ?? 0).Take((int)Limit).ToArray();
            Count = Results.Count();
        }
    }
}
