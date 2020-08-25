using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using StockMarket.ExcelAPI.Models;
using StockMarket.ExcelAPI.Repositories;
using StockMarket.ExcelAPI.Services;
namespace StockMarket.ExcelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
        private IExcelService es;
        public ExcelController(IExcelService serv)
        {
            es = serv;
        }
        [HttpGet]
        [Route("ImportStock/{*filePath}")]

        public IList<StockPrice> ImportStock(string filePath)
        {
            return (es.ExcelHelper(filePath));
        }
    }
}