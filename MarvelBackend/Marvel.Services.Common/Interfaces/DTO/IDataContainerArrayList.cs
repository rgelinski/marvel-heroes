using System.Collections.Generic;

namespace Marvel.Interfaces.DTO
{
    public interface IDataContainerArrayList<T> : IDataObject
        where T : IDataObject
    {
        int? Offset { get; }
        int? Limit { get; }
        int? Total { get; }
        int? Count { get; }
        ICollection<T> Results { get; }
    }
}
