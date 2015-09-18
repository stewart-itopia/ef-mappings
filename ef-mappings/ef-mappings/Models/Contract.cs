using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class Contract
    {
        public virtual string ContractId { get; set; }
        public virtual ICollection<ContractPart> ContractParts { get; set; }
    }
}