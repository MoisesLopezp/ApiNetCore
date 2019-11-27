using ApiAsp.Helpers;
using AutoMapper;
using CourseLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAsp.Profiles
{
    public class AuthorsProfile :Profile
    {
        public AuthorsProfile()
        {
            CreateMap<Author, Models.AuthorDto>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));

            CreateMap<Models.AuthorForCreationDto, Author>();
        }
    }
}
