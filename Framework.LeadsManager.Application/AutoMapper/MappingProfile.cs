
using Framework.LeadsManager.Application.Dtos;
using Framework.LeadsManager.Domain.Entities;

namespace AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeadDto, Lead>().ReverseMap();
            CreateMap<Lead, LeadInvitationDto>()
                .ForMember(dto => dto.ClientFirstName, opt => opt.MapFrom(src => src.Client.Name))
                .ForMember(dto => dto.JobId, opt => opt.MapFrom(src => src.JobId))
                .ForMember(dto => dto.Suburb, opt => opt.MapFrom(src => src.Client.Addreess.GetSuburb()))
                .ForMember(dto => dto.JobDescription, opt => opt.MapFrom(src => src.Job.Description))
                .ForMember(dto => dto.CategoryDescription, opt => opt.MapFrom(src => src.Job.Category.Description))
                .ForMember(dto => dto.Price, opt => opt.MapFrom(src => src.Job.Price))
                .ForMember(dto => dto.JobDateCreation, opt => opt.MapFrom(src => src.Job.CreatedAt)).ReverseMap();

            CreateMap<Lead, LeadAcceptedDto>()
                .ForMember(dto => dto.ClientFullName, opt => opt.MapFrom(src => src.Client.GetFullName()))
                .ForMember(dto => dto.JobId, opt => opt.MapFrom(src => src.JobId))
                .ForMember(dto => dto.Suburb, opt => opt.MapFrom(src => src.Client.Addreess.GetSuburb()))
                .ForMember(dto => dto.JobDescription, opt => opt.MapFrom(src => src.Job.Description))
                .ForMember(dto => dto.CategoryDescription, opt => opt.MapFrom(src => src.Job.Category.Description))
                .ForMember(dto => dto.FinalPrice, opt => opt.MapFrom(src => src.Job.PriceWithDiscount))
                .ForMember(dto => dto.JobDateCreation, opt => opt.MapFrom(src => src.Job.CreatedAt))
                .ForMember(dto => dto.Phone, opt => opt.MapFrom(src => src.Client.Phone))
                .ForMember(dto => dto.Email, opt => opt.MapFrom(src => src.Client.Email));
        }
    }
}