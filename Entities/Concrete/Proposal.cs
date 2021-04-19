using Core.Entities;
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
        public string UserName { get; set; }
    }
}
