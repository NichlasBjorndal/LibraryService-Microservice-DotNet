using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrderService.Models
{
    public class OrderServiceContext : DbContext
    {
        public OrderServiceContext (DbContextOptions<OrderServiceContext> options)
            : base(options)
        {
        }

        public DbSet<OrderService.Models.Order> Order { get; set; }
    }
}
