using System.ComponentModel.DataAnnotations.Schema;

namespace Univera.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string ManufacturerCode { get; set; }
        public double Amount { get; set; }
        [ForeignKey("ID")]
        public virtual ICollection<AmountType> AmountType { get; set; }
        public int KdvRate { get; set; }
        [ForeignKey("ID")]
        public virtual ICollection<ProductGroup> GroupCode { get; set; }
        [ForeignKey("ID")]
        public virtual ICollection<AdditionalProductGroup>? AdditionalProductGroupCode { get; set; }
        [ForeignKey("ID")]
        public virtual ICollection<EnumProductType> Type { get; set; }
        [ForeignKey("ID")]
        public virtual ICollection<EnumProductStatus> Status { get; set; }
        [ForeignKey("ID")]
        public virtual ICollection<EnumProductUnit> Unit { get; set; }
        public int Queue { get; set; }
        public int SerialTracking { get; set; }
        public DateTime ProductionDate { get; set; }
    }
}
