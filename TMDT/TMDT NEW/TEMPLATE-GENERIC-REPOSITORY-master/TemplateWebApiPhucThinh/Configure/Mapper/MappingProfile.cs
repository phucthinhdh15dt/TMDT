﻿using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateWebApiPhucThinh.Data.Models;
using TemplateWebApiPhucThinh.ModelValidation;

namespace TemplateWebApiPhucThinh.Configure.Mapper
{
    public class MappingProfile : AutoMapper.Profile
    {

        public MappingProfile()
        {
            CreateMap<Customer, CustomerModel>();
            CreateMap<CustomerModel, Customer>();
        }
    }
}
