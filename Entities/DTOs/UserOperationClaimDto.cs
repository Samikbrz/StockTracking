using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserOperationClaimDto : IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string OperationClaimName { get; set; }
    }
}
