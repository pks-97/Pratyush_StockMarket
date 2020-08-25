using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.ExcelAPI.Models;
namespace StockMarket.ExcelAPI.Repositories
{
    public interface IExcelRepository
    {

        public IList<StockPrice> ExcelHelper(string filePath);
    }
}
