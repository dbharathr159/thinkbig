using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFoodApI.Entities;

namespace DemoFoodApI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private MyContext context = null;
        public AdminRepository()
        {
            context = new MyContext();
        }
        public void AddMenuitem(Menu menu)
        {
            // throw new NotImplementedException();
            context.Menus.Add(menu);
            context.SaveChanges();
        }

        public void DeleteMenuitem(int menuid)
        {
            //throw new NotImplementedException();
            Menu menu = context.Menus.SingleOrDefault(i => i.Menuid == menuid);
            context.Menus.Remove(menu);
            context.SaveChanges();
        }

        public Customer GetCustomerByCustomerid(int customerid)
        {
            //throw new NotImplementedException();
            return context.Customers.SingleOrDefault(i => i.Customerid == customerid);
        }

        public Menu GetMenuByMenuid(int menuid)
        {
            // throw new NotImplementedException();
            return context.Menus.SingleOrDefault(i => i.Menuid == menuid);
        }

        public Order GetOrderByOrderid(int orderid)
        {
            //throw new NotImplementedException();
            return context.Orders.SingleOrDefault(i => i.Orderid == orderid);
        }

        public OrderItem GetOrderitemByOrderid(int orderitem)
        {
             throw new NotImplementedException();
            //return context.Orders.SingleOrDefault(i => i.Orderitem == orderitem);
        }

        public Payment GetPaymentByOrderid(int orderid)
        {
            // throw new NotImplementedException();
            return context.Payments.SingleOrDefault(i => i.Orderid == orderid);
        }

        public Payment GetPaymentByPaymentid(int paymentid)
        {
            //throw new NotImplementedException();
            return context.Payments.SingleOrDefault(i => i.Paymentid == paymentid);
        }

        public void ModifyOrder(Order order)
        {
            //throw new NotImplementedException();
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public void UpdateMenuitemById(int menuid)
        {
            throw new NotImplementedException();
           // context.Menus.Update(int menuid);
        }
    }
}
