using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFoodApI.Entities;
using DemoFoodApI.Repositories;

namespace DemoFoodApI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        
        private  ICustomerRepository _repository ;
            
        public CustomerController(ICustomerRepository repository)
        {
            
            _repository = repository;
        }

        //Add Orderitem
        [HttpPost]
        [Route("AddOrderitem")]
        public string AddOrderitem(OrderItem orderItem)
        {
            _repository.AddOrderitem(orderItem);
            return "OrderItem Added";
        }
        //Place Order
        [HttpPost]
        [Route("PlaceOrder")]
        public string PlaceOrder(Orders orders1)
        {
            _repository.PlaceOrder(orders1);
            return "Order Placed";
        }
        //ModifyOrder
        [HttpPut]
        [Route("ModifyOrder")]
        public string ModifyOrder(Orders orders1)
        {
            _repository.ModifyOrder(orders1);
            return "Modified Order";
        }
        //Cancel Order by Orderid
        [HttpDelete]
        [Route("CancelOrderByOrderid/{orderid}")]
        public string CancelOrderByOrderid(int orderid)
        {
            _repository.CancelOrderByOrderid(orderid);
            return "Order Cancelled";
        }
        //Get Menuitem By MenuName
        [HttpGet]
        [Route("GetMenuitemByMenuName/{menuname}")]
        public Menu GetMenuitemByMenuName(string menuname)
        {
            return _repository.GetMenuitemByMenuName(menuname);
        }
        //Menu GetMenuitems
        [HttpGet]
        [Route("GetMenuitem")]
        public List<Menu> GetMenuitems()
        {
            return _repository.GetMenuitems();
        }
        // Make Payment By Orderid
        [HttpPost]
        [Route("MakePayment")]
        public string MakePayment(Payment payment)
        {
            _repository.MakePayment(payment);
            return "Paid";
        }
        //TrackOrderStatusByOrderid
        [HttpGet]
        [Route("TrackOrderStatusByOrderid/{orderid}")]
        public string TrackOrderStatusByOrderid(int orderid)
        {
            return _repository.TrackOrderStatusByOrderid(orderid);
        }
        //Add customer
        [HttpPost]
        [Route("AddCustomer")]
        public string AddCustomer(Customer customer)
        {
            _repository.AddCustomer(customer);
            return "customer Added sucssesfully";
        }
      /*  [HttpDelete]
        [Route("DeleteCustomerBycustomerid/{customerid}")]
        public void DeleteCustomerBycustomerid(int customerid)
        {
            repository.DeleteCustomerBycustomerid(customerid);
            
        }*/
    }
}
