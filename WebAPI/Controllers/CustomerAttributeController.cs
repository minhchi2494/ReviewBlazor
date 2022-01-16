using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAttributeController : ControllerBase
    {
        private readonly ICustomerAttributeService _service;

        public CustomerAttributeController(ICustomerAttributeService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<List<CustomerAttributeModel>> getAll([FromQuery] CustomerSearch customerSearch)
        {
            return _service.getAll(customerSearch);
        }

        [HttpGet("{id}")]
        public Task<CustomerAttributeModel> getOne(int id)
        {
            return _service.getOne(id);
        }

        [HttpPost]
        public Task<bool> create(CustomerAttributeModel newCust)
        {
            return _service.Create(newCust);
        }

        [HttpPut]
        public Task<bool> edit(CustomerAttributeModel editCust)
        {
            return _service.Update(editCust);
        }

        [HttpDelete("{id}")]
        public Task<bool> delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
