﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Proposal : IEntity
    {
        public int Id { get; set; }
        public string ProposalNo { get; set; }
        public DateTime Date { get; set; }       
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public int Count { get; set; }        
        public string Barcode { get; set; }
        public decimal ProposalPrice { get; set; }
    }
}
