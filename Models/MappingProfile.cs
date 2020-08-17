using AutoMapper;
using WebApplication.DataAccess;

namespace WebApplication.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonDTO, Person>();
            CreateMap<Person, PersonDTO>();
        }
    }
}