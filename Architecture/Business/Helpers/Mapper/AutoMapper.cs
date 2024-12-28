using AutoMapper;
using Business.DTOs.Color;
using Business.DTOs.Model;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helpers.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<GetModelDto,Model>().ReverseMap();
            CreateMap<CreateModelDto,Model>().ReverseMap();
            CreateMap<UpdateModelDto,GetModelDto>().ReverseMap();

            CreateMap<GetColorDto, Color>().ReverseMap();
            CreateMap<CreateColorDto, Color>().ReverseMap();
            CreateMap<UpdateColorDto, GetColorDto>().ReverseMap();

        }
    }
}
