using System.Collections.Generic;

namespace ef_mappings.Models
{
    public class Part
    {
        public virtual string PartId { get; set; }
        public virtual ICollection<ContractPart> ContractParts { get; set; }
    }
}