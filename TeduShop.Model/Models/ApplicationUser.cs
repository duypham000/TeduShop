using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ApplicationUsers")]
    public class ApplicationUser
    {
        [Key]
        public string ID { get; set; }

        [MaxLength(256)]
        public string FullName { get; set; }

        [MaxLength(256)]
        public string Address { get; set; }

        public DateTime? BirthDay { get; set; }
        public string Email { get; set; }

        [Required]
        public string EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }

        [Required]
        public string PhoneNumberCofirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDateUtc { get; set; }

        [Required]
        public bool LockoutEnabled { get; set; }

        [Required]
        public int AccessFailedCount { get; set; }

        public string UserName { get; set; }

        public virtual IEnumerable<IdentityUserLogin> IdentityUserLogins { get; set; }
        public virtual IEnumerable<IdentityUserClaim> IdentityUserClaims { get; set; }
        public virtual IEnumerable<IdentityUserRole> IdentityUserRoles { get; set; }
    }
}