using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AccountAPI.Services;
using StockMarket.AccountAPI.Models;
namespace StockMarket.AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService service;
        public AccountController(IAccountService serv)
        {
            service = serv;
        }
        [HttpGet]
        [Route("Validate/{uname}/{pwd}")]
        public IActionResult Validate(string uname, string pwd)
        {
            try
            {
                User useTest = service.Validate(uname, pwd);
                if (useTest == null)
                {
                    return Content("Invalid User");
                }
                else
                {
                    return Ok(useTest);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(700, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(User item)
        {
            try
            {
                service.AddUser(item);
                return Ok();
            }
            catch(Exception ex){
                return StatusCode(500, ex.Message);
            }
        }
    }
}