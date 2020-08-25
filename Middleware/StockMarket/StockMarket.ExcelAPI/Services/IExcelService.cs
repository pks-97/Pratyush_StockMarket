using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.ExcelAPI.Models;
namespace StockMarket.ExcelAPI.Services
{
    public interface IExcelService
    {
        public IList<StockPrice> ExcelHelper(string filePath);
    }
}
