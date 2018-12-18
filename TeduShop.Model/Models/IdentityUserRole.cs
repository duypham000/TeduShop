using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("IdentityUserRoles")]
    public class IdentityUserRole
    {
        [Key]
        [MaxLength(128)]
        [Column(Order = 1)]
        public string UserID { get; set; }

        [Key]
        [MaxLength(128)]
        [Column(Order = 2)]
        public string RoleID { get; set; }

        [MaxLength(128)]
        public string IdentityRoleID { get; set; }

        [MaxLength(128)]
        public string ApplicationUserID { get; set; }

        [ForeignKey("IdentityRoleID")]
        public virtual IdentityRole IdentityRoles { get; set; }

        [ForeignKey("ApplicationUserID")]
        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}