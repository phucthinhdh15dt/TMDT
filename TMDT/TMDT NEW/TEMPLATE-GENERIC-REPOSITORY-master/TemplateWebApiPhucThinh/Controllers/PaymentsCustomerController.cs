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
    public class PaymentCustomerController : ControllerBase
    {
        //ICustomerRepository CustomerRepository;
        //IMapper Mapper;
        //IConfiguration Configuration;
        private readonly IPaymentsCustomerRepository _repository;

        public PaymentCustomerController(IPaymentsCustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] PaymentsCustomer PaymentCustomer)
        {
            PaymentCustomer.Id = Guid.NewGuid() + "";
            return Ok(_repository.Create(PaymentCustomer));
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
        public IActionResult Update(string id, [FromBody] PaymentsCustomer PaymentCustomer)
        {
            return Ok(_repository.Update(id, PaymentCustomer));
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
