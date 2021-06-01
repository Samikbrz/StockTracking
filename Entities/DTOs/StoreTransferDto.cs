using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class StoreTransferDto : IDto
    {
        public int Id { get; set; }
        public string TransferNo { get; set; }
        public DateTime Date { get; set; }
        public string SourceStoreName { get; set; }
        public string SourceShelfName { get; set; }
        public string SourceDrawerName { get; set; }
        public string TergetStoreName { get; set; }
        public string TargetShelfName { get; set; }
        public string TargetDrawerName { get; set; }
        public string UserName { get; set; }
    }
}
