using System;
using System.Collections.Generic;
using TemplateWebApiPhucThinh.RepositoryGeneric;

namespace TemplateWebApiPhucThinh.Data.Models
{
    public partial class Product : IEntity
    {
        public int Identity { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }
    }
}
