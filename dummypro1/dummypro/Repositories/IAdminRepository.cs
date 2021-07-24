using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFoodApI.Entities;

namespace DemoFoodApI.Repositories
{
    public interface IAdminRepository
    {
        public void AddMenuitem(Menu menu);//1
        public void UpdateMenuitem(Menu menu);//2
        public void DeleteMenuitem(int menuid);//3
        List<Menu> GetMenuitems();//4
        Menu GetMenuByMenuid(int menuid);//5
        OrderItem GetOrderItemByOrderItemId(int orderitemid);//6
        Orders GetOrderByOrderid(int orderid);//7
        void ModifyOrder(Orders orders1);//8
        List<Customer> GetCustomers();//9
        Customer GetCustomerByCustomerid(int customerid);//10
        List<Payment> GetPaymentDetails();//11
        Payment GetPaymentDetailsByOrderid(int orderid);//12
        
    }
}
