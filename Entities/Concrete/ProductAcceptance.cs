using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductAcceptance : IEntity
    {
        public int Id { get; set; }
        public string ProductRegistaritonNumber { get; set; }
        public DateTime AcceptanceDate { get; set; }       
        public string UserName { get; set; }
        public string InvoiceNo { get; set; }
        public int CompanyId { get; set; }      
    }
}
