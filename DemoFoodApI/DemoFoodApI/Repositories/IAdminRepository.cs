using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFoodApI.Entities;

namespace DemoFoodApI.Repositories
{
    interface IAdminRepository
    {
        void AddMenuitem(Menu menu);
        void UpdateMenuitemById(int menuid);
        void DeleteMenuitem(int menuid);
        Menu GetMenuByMenuid(int menuid);
        OrderItem GetOrderitemByOrderid(int orderitem);
        Order GetOrderByOrderid(int orderid);
        void ModifyOrder(Order order);
        Customer GetCustomerByCustomerid(int customerid);
        Payment GetPaymentByOrderid(int orderid);
        Payment GetPaymentByPaymentid(int paymentid);
    }
}
