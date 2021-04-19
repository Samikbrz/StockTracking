using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StoreTransfer : IEntity
    {
        public int Id { get; set; }
        public string TransferNo { get; set; }        
        public DateTime Date { get; set; }
        public string UserName { get; set; }         
        public Store Store { get; set; }
        public Store TargetStore { get; set; }
    }
}
