

using System.Collections.Generic;
using TemplateWebApiPhucThinh.Data.Model;
using TemplateWebApiPhucThinh.Repository.IRepository;
using TemplateWebApiPhucThinh.RepositoryGeneric;

namespace TemplateWebApiPhucThinh.Repository.Repository
{
    public class ProcedureRepository : GenericRepository<Procedure>, IProcedureRepository
    {
        public ProcedureRepository(ChoThueXeContext dbContext) : base(dbContext)
        {
        }
    }
}

