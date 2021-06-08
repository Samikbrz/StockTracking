﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProposalDto : IDto
    {
        public int Id { get; set; }
        public string ProposalNo { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }       
        public string Barcode { get; set; }
        public int Count { get; set; }
        public decimal ProposalPrice { get; set; }
    }
}
