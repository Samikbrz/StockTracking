using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Proposal : IEntity
    {
        public int ProposalId { get; set; }
        public string ProposalNo { get; set; }
        public DateTime Date { get; set; }
        public string Company { get; set; }
        public string UserName { get; set; }
    }
}
