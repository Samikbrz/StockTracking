using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ExchhangeRate : IEntity
    {
        public int ExchhangeRateId { get; set; }
        public decimal USD { get; set; }
        public decimal EURO { get; set; }
        public decimal STERLIN { get; set; }
    }
}
