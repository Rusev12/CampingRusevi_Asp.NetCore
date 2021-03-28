namespace CampingRusevi.Services.Data.OwnerServices
{
    using System.Collections.Generic;

    public interface IOwnerService
    {
        IEnumerable<T> GetAll<T>();
    }
}
