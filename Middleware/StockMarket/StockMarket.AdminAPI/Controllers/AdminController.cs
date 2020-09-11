using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AdminAPI.Services;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminService service;
        public AdminController(IAdminService serv)
        {
            service = serv;
        }
        [HttpGet]
        [Route("Validate/{uname}/{pwd}")]
        public IActionResult Validate(string uname, string pwd)
        {
            try
            {
                bool adminTest = service.Validate(uname, pwd);
                if (!adminTest)
                {
                    return Content("Invalid User");
                }
                else
                {
                    return Ok(adminTest);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(700, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany(Company item)
        {
            try
            {
                service.Add(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("DeleteCompany/{code}")]
        public IActionResult Delete(string code)
        {
            try
            {
                service.Delete(code);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddIPO")]
        public IActionResult AddIPO(IPO item)
        {
            try
            {
                service.AddIPO(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("DeleteIPO")]
        public IActionResult DeleteIPO(IPO item)
        {
            try
            {
                service.DeleteIPO(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("EditCompany")]
        public IActionResult Edit(Company item)
        {
            try
            {
                service.Edit(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("EditIPO")]
        public IActionResult EditIPO(IPO item)
        {
            try
            {
                service.EditIPO(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllCompany/{code}")]
        public IActionResult Index(string code)
        {
            try
            {
                Company co = service.GetCompanyById(code);
                return Ok(co);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllCompanies")]
        public IActionResult GetAll()
        {
            try
            {
                IEnumerable<Company> companies = service.GetAllCompanies();
                return Ok(companies);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}