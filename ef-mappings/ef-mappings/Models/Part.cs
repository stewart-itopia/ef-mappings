using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class Part
    {
        public virtual string PartId { get; set; }
        public virtual ICollection<ContractPart> ContractParts { get; set; }
    }
}