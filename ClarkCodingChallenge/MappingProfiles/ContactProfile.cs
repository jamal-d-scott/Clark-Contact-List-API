using AutoMapper;
using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.Models.MappingModels;


namespace ClarkCodingChallenge.MappingProfiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactsViewModel, ContactItem>().ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.FirstName))
                                                       .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.LastName))
                                                       .ForMember(dest => dest.EmailAddress, opts => opts.MapFrom(src => src.EmailAddress));
        }
    }
}
