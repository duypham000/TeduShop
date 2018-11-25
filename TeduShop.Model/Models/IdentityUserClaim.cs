using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("IdentityUserClaims")]
    public class IdentityUserClaim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string UserID { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        [MaxLength(128)]
        public string ApplicationUserID { get; set; }

        [ForeignKey("ApplicationUserID")]
        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}