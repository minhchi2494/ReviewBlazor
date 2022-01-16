using BlazorApp.Model;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class CustomerAttributeView
    {
        [Inject]
        public ICustomerAttributeService _service { get; set; }
        List<CustomerAttributeModel> model;
        CustomerSearch customerSearch = new CustomerSearch();

        protected override async Task OnInitializedAsync()
        {
            model = await _service.getAll(customerSearch);
        }

        private async Task SearchForm(EditContext context)
        {
            model = await _service.getAll(customerSearch);
        }
    }
}
