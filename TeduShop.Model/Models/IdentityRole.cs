using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("IdentityRoles")]
    public class IdentityRole
    {
        [Key]
        [MaxLength(128)]
        public string ID { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<IdentityUserRole> IdentityUserRoles { get; set; }
    }
}