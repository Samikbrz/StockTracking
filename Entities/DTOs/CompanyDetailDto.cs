using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CompanyDetailDto : IDto
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ProposalNo { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
    }
}
