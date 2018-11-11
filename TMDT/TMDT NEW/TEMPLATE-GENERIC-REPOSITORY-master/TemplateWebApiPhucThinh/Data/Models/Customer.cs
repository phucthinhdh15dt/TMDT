using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TemplateWebApiPhucThinh.RepositoryGeneric;

namespace TemplateWebApiPhucThinh.Data.Models
{
    public partial class Customer : IEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Identity { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsDelete { get; set; }
        
    }
}
