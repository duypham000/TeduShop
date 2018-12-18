using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("IdentityUserLogins")]
    public class IdentityUserLogin
    {
        [Key]
        [MaxLength(128)]
        public string UserID { get; set; }

        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }

        [MaxLength(128)]
        public string ApplicationUserID { get; set; }

        [ForeignKey("ApplicationUserID")]
        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}