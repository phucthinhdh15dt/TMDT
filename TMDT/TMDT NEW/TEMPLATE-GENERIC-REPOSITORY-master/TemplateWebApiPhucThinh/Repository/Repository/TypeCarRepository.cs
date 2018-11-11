

using System.Collections.Generic;
using TemplateWebApiPhucThinh.Data.Model;
using TemplateWebApiPhucThinh.Repository.IRepository;
using TemplateWebApiPhucThinh.RepositoryGeneric;

namespace TemplateWebApiPhucThinh.Repository.Repository
{
    public class TypeCarRepository : GenericRepository<TypeCar>, ITypeCarRepository
    {
        public TypeCarRepository(ChoThueXeContext dbContext) : base(dbContext)
        {
        }
    }
}

