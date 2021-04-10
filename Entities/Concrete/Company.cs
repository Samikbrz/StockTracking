using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Company : IEntity
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Adres { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax { get; set; }
        public string TaxNo { get; set; }
        public string TaxName { get; set; } 
        public int ProposalId { get; set; }
    }
}
