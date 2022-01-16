using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repository;
using WebAPI.Model;

namespace WebAPI.Services
{
    public class CustomerAttributeService : ICustomerAttributeService
    {
        private readonly CustomerAttributeContext _context;

        public CustomerAttributeService(CustomerAttributeContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerAttributeModel>> getAll(CustomerSearch customerSearch)
        {
            var list = _context.CustomerAttributeModels.ToList();
            if (!string.IsNullOrEmpty(customerSearch.AttributeMaster))
            {
                list = list.Where(c=>c.AttributeMaster.ToLower().Contains(customerSearch.AttributeMaster.ToLower())).ToList();
                return list;
            }
            else
            {
                return list;
            }
        }

        public async Task<CustomerAttributeModel> getOne(int id)
        {
            var cust = _context.CustomerAttributeModels.SingleOrDefault(c => c.Id.Equals(id));
            if (cust != null)
            {
                return cust;
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> Create(CustomerAttributeModel newCust)
        {
            var cust = _context.CustomerAttributeModels.SingleOrDefault(c=>c.Id.Equals(newCust.Id));
            if (cust == null)
            {
                _context.CustomerAttributeModels.Add(newCust);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            var cust = _context.CustomerAttributeModels.SingleOrDefault(c => c.Id.Equals(id));
            if (cust != null)
            {
                _context.CustomerAttributeModels.Remove(cust);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<bool> Update(CustomerAttributeModel editCust)
        {
            var cust = _context.CustomerAttributeModels.SingleOrDefault(c => c.Id.Equals(editCust.Id));
            if (cust != null)
            {
                cust.AttributeMaster = editCust.AttributeMaster;
                cust.AttributeValuesCode = editCust.AttributeValuesCode;
                cust.Description = editCust.Description;
                cust.Parent = editCust.Parent;
                cust.EffectiveDate = editCust.EffectiveDate;
                cust.ValidUntil = editCust.ValidUntil;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
