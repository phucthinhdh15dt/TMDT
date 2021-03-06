﻿

using System.Collections.Generic;
using TemplateWebApiPhucThinh.Data.Model;
using TemplateWebApiPhucThinh.Repository.IRepository;
using TemplateWebApiPhucThinh.RepositoryGeneric;

namespace TemplateWebApiPhucThinh.Repository.Repository
{
    public class PartnerCarRepository : GenericRepository<PartnerCar>, IPartnerCarRepository
    {
        public PartnerCarRepository(ChoThueXeContext dbContext) : base(dbContext)
        {
        }
    }
}

