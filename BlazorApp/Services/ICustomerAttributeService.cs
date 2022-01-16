﻿using BlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public interface ICustomerAttributeService
    {
        Task<List<CustomerAttributeModel>> getAll(CustomerSearch customerSearch);
        Task<CustomerAttributeModel> getOne(int id);
        Task<bool> Create(CustomerAttributeModel newCust);
        Task<bool> Update(CustomerAttributeModel editCust);
        Task<bool> Delete(int id);
    }
}
