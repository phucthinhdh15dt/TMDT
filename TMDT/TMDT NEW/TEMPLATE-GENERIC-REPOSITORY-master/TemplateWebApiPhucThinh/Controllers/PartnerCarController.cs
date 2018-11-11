using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using TemplateWebApiPhucThinh.Data.Model;
using TemplateWebApiPhucThinh.Data.Models;
using TemplateWebApiPhucThinh.ModelValidation;
using TemplateWebApiPhucThinh.Repository.IRepository;

namespace TemplateWebApiPhucThinh.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PartnerCarController : ControllerBase
    {
        //ICustomerRepository CustomerRepository;
        //IMapper Mapper;
        //IConfiguration Configuration;
        private readonly IPartnerCarRepository _repository;

        public PartnerCarController(IPartnerCarRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] PartnerCar PartnerCar)
        {
            PartnerCar.Id = Guid.NewGuid() + "";
            return Ok(_repository.Create(PartnerCar));
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(_repository.Delete(id));
        }
        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult Update(string id, [FromBody] PartnerCar PartnerCar)
        {
            return Ok(_repository.Update(id, PartnerCar));
        }
        [HttpGet]
        [Route("Paging/{pagesize}/{pageNow}")]
        public IActionResult Paging(int pagesize, int pageNow)
        {

            return Ok(_repository.Paging(pagesize, pageNow, "name"));

        }
        [HttpDelete]
        [Route("DeleteEnable/{id}")]
        public IActionResult DeleteEnable(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }
            return Ok(_repository.DeleteEnable(id));
        }
    }
}
