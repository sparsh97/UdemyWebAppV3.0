using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyWeb.Models
{
    public class OrderRepository :IOrderRepository
    {

        private readonly DataContext _appDbContext;
        public OrderRepository(DataContext appDbContext)
        {
            _appDbContext = appDbContext;
          
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
