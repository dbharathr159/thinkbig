using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFoodApI.Entities;

namespace DemoFoodApI.Repositories
{
    public interface ICustomerRepository
    {
        public void AddCustomer(Customer customer);
       // public void DeleteCustomerBycustomerid(int customerid);
        List<Menu> GetMenuitems();//1
        Menu GetMenuitemByMenuName(string menuname);//2
        public void AddOrderitem(OrderItem orderItem);//3
        public void PlaceOrder(Orders orders1);//6
        public void ModifyOrder(Orders orders1);//7
        public void CancelOrderByOrderid(int orderid);//4
        public string TrackOrderStatusByOrderid(int orderid);//8
        public void MakePayment(Payment payment);//5
       }
}
