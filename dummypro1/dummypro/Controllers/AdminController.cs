using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFoodApI.Entities;
using DemoFoodApI.Repositories;
using dummypro;

namespace DemoFoodApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminRepository _repository;
        public AdminController(IAdminRepository repository)
        {
            _repository=repository;

        }
        
        //Add Menuitem
        [HttpPost]
        [Route("PostMenu")]
        public IActionResult AddMenuitem(Menu menu)
        {
            try
            {
                _repository.AddMenuitem(menu);
                return Ok("Item Added");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // Get Customer by Menuid
        [HttpGet]
        [Route("GetMenuByMenuid/{menuid}")]
        public IActionResult GetMenuByMenuid(int menuid)
        {
            Menu menu = _repository.GetMenuByMenuid(menuid);
            if(menu!=null)
                {
                return Ok(menu);
            }
            else
            {
                return NotFound("Invalid Menu");
            }
            
        }
        //delete menu by Menu id
        [HttpDelete]
        [Route("DeleteMenuByMenuid/{menuid}")]
        public IActionResult DeleteMenuitem(int menuid)
        {
            try
            {
                _repository.DeleteMenuitem(menuid);
                return Ok("Item Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //update Menuitem
        [HttpPut]
        [Route("UpdateMenuitem")]
        public IActionResult UpdateMenuitem(Menu menu)
        {
            try
            {
                _repository.UpdateMenuitem(menu);
                return Ok("Item Update");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //Menu GetMenuitems
        [HttpGet]
        [Route("GetMenuitem")]
        public List<Menu> GetMenuitems()
        {
            return _repository.GetMenuitems();
        }


        // Get Orderitem by orderitemid
        [HttpGet]
        [Route("GetOrderItemByOrderItemId/{orderitemid}")]
        public IActionResult GetOrderItemByOrderItemId(int orderitemid)
        {
            OrderItem orderItem = _repository.GetOrderItemByOrderItemId(orderitemid);
            if(orderItem != null)
            {
                return Ok(orderItem);
            }
            else
            {
                return NotFound("Invalid Orderitem");
            }
        }
        // Get Order by orderid
        [HttpGet]
        [Route("GetOrderByOrderid/{orderid}")]
        public IActionResult GetOrderByOrderid(int orderid)
        {
            Orders orders = _repository.GetOrderByOrderid(orderid);
            if (orders != null)
            {
                return Ok(orders);
            }
            else
            {
                return NotFound("Invalid Order");
            }
       
        }
        //Modify Order
        [HttpPut]
        [Route("ModifyOrder")]
        public IActionResult ModifyOder(Orders orders1)
        {
            try
            {
                _repository.ModifyOrder(orders1);
                return Ok("Order Modified");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        //Menu GetCustomerss
        [HttpGet]
        [Route("GetCustomers")]
        public List<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }

        // Get Customer by Customerid
        [HttpGet]
        [Route("GetCustomerByCustomerid/{customerid}")]
        public IActionResult GetCustomerByCustomerid(int customerid)
        {
            Customer customer= _repository.GetCustomerByCustomerid(customerid);
            if (customer != null)
            {
                return Ok(customer);
            }
            else
            {
                return NotFound("Invalid Customer");
            }
        }

        // Get Payment by Orderid
        [HttpGet]
        [Route("GetPaymentDetailsByOrderid/{orderid}")]
        public IActionResult GetPaymentDetailsByOrderid(int orderid)
        {
            Payment payment = _repository.GetPaymentDetailsByOrderid(orderid);
            if (payment != null)
            {
                return Ok(payment);
            }
            else
            {
                return NotFound("Invalid Payment");
            }
        }

        //Payments List
        [HttpGet]
        [Route("GetPaymentDetails")]
        public List<Payment> GetPaymentDetails()
        {
            return _repository.GetPaymentDetails();
        }
    }
}


