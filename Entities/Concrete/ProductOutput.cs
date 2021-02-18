using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductOutput : IEntity
    {
        public int ProductOutputId { get; set; }
        public string ExitNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public string UserName { get; set; }

        public int CurrentCompanyId { get; set; }
        public Company Company { get; set; }
    }
}
