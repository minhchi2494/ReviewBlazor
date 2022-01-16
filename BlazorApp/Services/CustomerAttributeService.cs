using BlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class CustomerAttributeService : ICustomerAttributeService
    {
        public HttpClient _httpClient;

        public CustomerAttributeService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<CustomerAttributeModel>> getAll(CustomerSearch customerSearch)
        {
            string url = $"/api/CustomerAttribute?AttributeMaster={customerSearch.AttributeMaster}";
            var result = await _httpClient.GetFromJsonAsync<List<CustomerAttributeModel>>(url);
            return result;
        }

        public async Task<CustomerAttributeModel> getOne(int id)
        {
            string url = $"/api/CustomerAttribute/{id}";
            var result = await _httpClient.GetFromJsonAsync<CustomerAttributeModel>(url);
            return result;
        }

        public Task<bool> Create(CustomerAttributeModel newCust)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(CustomerAttributeModel editCust)
        {
            throw new NotImplementedException();
        }
    }
}
