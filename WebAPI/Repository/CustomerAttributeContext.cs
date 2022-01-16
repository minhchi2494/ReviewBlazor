using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Repository
{
    public class CustomerAttributeContext : DbContext
    {
        public CustomerAttributeContext(DbContextOptions options) : base(options) { }
        public DbSet<CustomerAttributeModel> CustomerAttributeModels { get; set; }
    }
}
