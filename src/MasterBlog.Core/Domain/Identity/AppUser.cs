using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MasterBlog.Core.Domain.Identity
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>
    {
        [Required]
        [MaxLength(100)]
        public required string LastName { get; set; }
        public bool IsActive { get; set; }
        public string? RefreshToke { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? Dob { get; set; }
        [MaxLength(500)]
        public string? Avartar { get; set; }
        public DateTime? VipStartDate { get; set; }
        public DateTime? VipExpireDate { get; set; }
        public DateTime? LateLoginDate { get; set; }
        public Double Balance { get; set; }


    }
}
