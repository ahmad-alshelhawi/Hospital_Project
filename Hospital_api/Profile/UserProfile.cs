using AutoMapper;

using Hospital.entities;
using Hospital.Models;
using Hospital_entities;

namespace Hospital.api.profile
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            this.CreateMap<User, UserCreateMapper>().ReverseMap();
        }
    }

}
