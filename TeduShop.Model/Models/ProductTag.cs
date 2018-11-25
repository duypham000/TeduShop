using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 2)]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { get; set; }
    }
}