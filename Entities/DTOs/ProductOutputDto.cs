using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductOutputDto : IDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public int Count { get; set; }
        public string ExitNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
    }
}
