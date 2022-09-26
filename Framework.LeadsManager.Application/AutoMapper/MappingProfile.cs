
using Framework.LeadsManager.Application.Dtos;
using Framework.LeadsManager.Domain.Entities;

namespace AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeadDto, Lead>().ReverseMap();
        }
    }
}