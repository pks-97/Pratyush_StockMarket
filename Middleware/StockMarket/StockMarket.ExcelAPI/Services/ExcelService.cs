using StockMarket.ExcelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.ExcelAPI.Repositories;
namespace StockMarket.ExcelAPI.Services
{
    public class ExcelService : IExcelService
    {
        private IExcelRepository ar;

        public ExcelService(IExcelRepository rep)
        {
            ar = rep;
        }
        public IList<StockPrice> ExcelHelper(string filePath)
        {
            return (ar.ExcelHelper(filePath));
        }
    }
}
