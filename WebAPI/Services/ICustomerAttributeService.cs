using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repository;
using WebAPI.Model;

namespace WebAPI.Services
{
    public interface ICustomerAttributeService 
    {
        Task<List<CustomerAttributeModel>> getAll(CustomerSearch customerSearch);
        Task<CustomerAttributeModel> getOne(int id);
        Task<bool> Create(CustomerAttributeModel newCust);
        Task<bool> Update(CustomerAttributeModel editCust);
        Task<bool > Delete(int id);
    }
}
