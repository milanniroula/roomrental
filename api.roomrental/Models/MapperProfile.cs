using api.roomrental.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.Models
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {
            CreateMap<ApplicationUser, UserRegistrationViewModel>()
                .ForMember(dao => dao.UserName, opt => opt.MapFrom(user => user.Email))
                .ReverseMap();
        }
    }
}
