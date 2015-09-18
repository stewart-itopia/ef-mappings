namespace ef_mappings.Models
{
    public class ContractPart
    {
        public virtual string ContractId { get; set; }
        public virtual string PartId { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual Part Part { get; set; }
        public virtual string Date { get; set; } //additional info
        public virtual decimal Price { get; set; } //additional info
    }
}