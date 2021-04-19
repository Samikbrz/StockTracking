using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductOutput : IEntity
    {
        public int Id { get; set; }
        public string ExitNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public string UserName { get; set; }
        public int CompanyId { get; set; }
    }
}
