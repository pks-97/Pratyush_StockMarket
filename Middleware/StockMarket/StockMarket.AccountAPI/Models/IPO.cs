using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace StockMarket.AccountAPI.Models
{
    public class IPO
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string StockExchange { get; set; }
        [Required]
        public string PricePerShare { get; set; }
        [Required]
        public int TotalShares { get; set; }
        [Required]
        public DateTime OpenDataTime { get; set; }
        public string Remarks { get; set; }
    }
}
