using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ModelDto : IDto
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string BrandName { get; set; }       
        public string ModelDefination { get; set; }
        public string OriginalBarcode { get; set; }
    }
}
