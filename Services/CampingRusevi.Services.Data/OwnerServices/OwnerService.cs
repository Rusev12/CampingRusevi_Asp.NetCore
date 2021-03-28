namespace CampingRusevi.Services.Data.OwnerServices
{
    using System.Collections.Generic;
    using System.Linq;
    using CampingRusevi.Data.Common.Repositories;
    using CampingRusevi.Services.Mapping;

    public class OwnerService : IOwnerService
    {
        private readonly IDeletableEntityRepository<CampingRusevi.Data.Models.Owner> settingsRepository;

        public OwnerService(IDeletableEntityRepository<CampingRusevi.Data.Models.Owner> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
