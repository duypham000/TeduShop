using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatitics")]
    public class VisitorStatitic
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}