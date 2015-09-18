using System.Collections.Generic;

namespace ef_mappings.Models
{
    public class Contract
    {
        public virtual string ContractId { get; set; }
        public virtual ICollection<ContractPart> ContractParts { get; set; }
    }
}