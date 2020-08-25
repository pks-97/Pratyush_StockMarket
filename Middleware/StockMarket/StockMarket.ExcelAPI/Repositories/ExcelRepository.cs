using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.ExcelAPI.Models;
using StockMarket.ExcelAPI.DBAccess;
using OfficeOpenXml;
using System.IO;

namespace StockMarket.ExcelAPI.Repositories
{
    //AdminDBContext context = new AdminDBContext();
    public class ExcelRepository : IExcelRepository
    {
        private ExcelDBContext context;

        public ExcelRepository(ExcelDBContext context)
        {
            this.context = context;
        }
        public IList<StockPrice> ExcelHelper(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            string fileName = file.Name;
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                //int totalRows = worksheet.Dimension.Rows;
                int totalRows = worksheet.Dimension.Rows;

                List<StockPrice> stockPrices = new List<StockPrice>();
                for (int i = 2; i <= totalRows; i++)
                {
                    stockPrices.Add(new StockPrice
                    {
                        CompanyCode = worksheet.Cells[i, 1].ToString().Trim(),
                        StockExchange = worksheet.Cells[i, 2].ToString().Trim(),
                        CurrentPrice = double.Parse(worksheet.Cells[i, 3].ToString().Trim()),
                        Date = DateTime.Parse(worksheet.Cells[i, 4].ToString().Trim()),
                        Time = worksheet.Cells[i, 5].ToString().Trim()
                    });
                }
                context.StockPrices.AddRange(stockPrices);
                context.SaveChanges();
                return stockPrices;
            }
            //context.StockPrices.AddRange(stockPrices);
            //throw new NotImplementedException();
        }
    }
}
