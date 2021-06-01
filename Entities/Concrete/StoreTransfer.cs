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
        public int SourceStoreId { get; set; }
        public int SourceShelfId { get; set; }
        public int SourceDrawerId { get; set; }
        public int TargetStoreId { get; set; }
        public int TargetShelfId { get; set; }
        public int TargetDrawerId { get; set; }
        public int UserId { get; set; }
    }
}
