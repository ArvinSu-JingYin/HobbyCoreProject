﻿using AutoMapper;
using JHobby.Repository.Models.Dto;
using JHobby.Repository.Models.Entity;
using JHobby.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHobby.Service.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<CategoryDto, CategoryModel>();
			CreateMap<CategoryCreateDto, CreateCategoryModel>();
            CreateMap<ActivityPageDto, ActivityPageModel>();
            CreateMap<MemberStatusDto, MemberStatusModel>();
            CreateMap<ActivityStatusDto, ActivityStatusModel>().ReverseMap();
        }
    }
}