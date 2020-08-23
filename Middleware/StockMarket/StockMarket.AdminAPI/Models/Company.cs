﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.AdminAPI.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        [StringLength(25)]
        public string CompanyCode { get; set; }
        [Required]
        [StringLength(25)]
        public string CompanyName { get; set; }
        [StringLength(30)]
        public string CEO { get; set; }
        public IEnumerable<StockPrice> StockPrices { get; set; } //Navigation Prop
        [Required]
        public string TurnOver { get; set; }
        [Required]
        public String Board { get; set; }
        public string Writeup { get; set; }
        [Required]
        public string StockCode { get; set; }
    }
}