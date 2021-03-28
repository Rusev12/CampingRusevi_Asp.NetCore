namespace CampingRusevi.Web.ViewModels.Owner
{
    using AutoMapper;
    using CampingRusevi.Services.Mapping;

    public class OwnerViewModel : IMapFrom<Data.Models.Owner>, IHaveCustomMappings
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Data.Models.Owner, OwnerViewModel>().ForMember(
                m => m.Name,
                m => m.MapFrom(m => m.FullName));
        }
    }
}
