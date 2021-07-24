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
        public AdminRepository(MyContext context)
        {
            this.context = context;
        }
        public void AddMenuitem(Menu menu)
        {
            context.Add(menu);
            context.SaveChanges();
        }
        public void DeleteMenuitem(int menuid)
        {
            Menu menu = context.Menus.SingleOrDefault(i => i.Menuid == menuid);
            context.Remove(menu);
            context.SaveChanges();
        }
        public Customer GetCustomerByCustomerid(int customerid)
        {
            Customer customer = context.Customers.SingleOrDefault(i => i.Customerid == customerid);
            return customer;
        }
        public Customer GetCustomers(Customer customer)
        {
            return customer;
        }
        public Menu GetMenuByMenuid(int menuid)
        {
            Menu menu = context.Menus.SingleOrDefault(i => i.Menuid == menuid);
            return menu;
        }
        public Orders GetOrderByOrderid(int orderid)
        {
            Orders order = context.Orders1.SingleOrDefault(i => i.Orderid == orderid);
            return order;
        }
        public OrderItem GetOrderItemByOrderItemId(int orderitemid)
        {
            OrderItem orderItem = context.OrderItems.SingleOrDefault(i => i.OrderItemId == orderitemid);
            return orderItem;
        }
       
       
        public void ModifyOrder(Orders orders1)
        {
            context.Orders1.Update(orders1);
            context.SaveChanges();
        }
        public void UpdatePaymentStatus(Payment payment)
        {
            context.Payments.Update(payment);
        }
        public void UpdateMenuitem(Menu menu)
        {
            context.Menus.Update(menu);
            context.SaveChanges();
        }
        public List<Menu> GetMenuitems()
        {
            return context.Menus.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }

        public List<Payment> GetPaymentDetails()
        {
            return context.Payments.ToList();
        }

        public Payment GetPaymentDetailsByOrderid(int orderid)
        {
            Payment payment = context.Payments.SingleOrDefault(i => i.Orderid == orderid);
            return payment;
        }

       
    }
}
