﻿using AutoMapper;
using Entity.Dtos.RolUserDTO;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Mappers.Profiles
{
    public class RolUserProfile : Profile
    {
        public RolUserProfile() 
        {
            CreateMap<RolUser, RolUserDto>().ReverseMap();
        } 
    }
}
