using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFoodApI.Entities;

namespace DemoFoodApI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private MyContext context = null;
        public CustomerRepository(MyContext context)
        {
            this.context = context;
        }

        public void AddCustomer(Customer customer)
        {
            context.Add(customer);
            context.SaveChanges();
        }
        

        public void AddOrderitem(OrderItem orderItem)
        {
            
            context.Add(orderItem);
            context.SaveChanges();
        }

        public void CancelOrderByOrderid(int orderid)
        {
            Orders order = context.Orders1.SingleOrDefault(i => i.Orderid == orderid);
            context.Remove(order);
            context.SaveChanges();
        }

      /*  public void DeleteCustomerBycustomerid(int customerid)
        {
            Customer customer = context.Customers.SingleOrDefault(i => i.Customerid == customerid);
            context.Remove(customer);
            context.SaveChanges();
        }*/

        public Menu GetMenuitemByMenuName(string menuname)
        {
            Menu menu = context.Menus.SingleOrDefault(i => i.MenuName == menuname);
            return menu;
        }

        public List<Menu> GetMenuitems()
        {
            return context.Menus.ToList();
        }

        public void MakePayment(Payment payment)
        {
            context.Add(payment);
            context.SaveChanges();
        }

        public void ModifyOrder(Orders orders1)
        {
            context.Orders1.Update(orders1);
            context.SaveChanges();
        }

        public void PlaceOrder(Orders orders1)
        {
            context.Add(orders1);
            context.SaveChanges();
        }

        public string TrackOrderStatusByOrderid(int orderid)
        {
            Payment payment = context.Payments.SingleOrDefault(i => i.Orderid == orderid);
            return payment.Status;
        }
    }
}
