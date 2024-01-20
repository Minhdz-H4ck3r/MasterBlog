using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterBlog.Core.Domain.Content
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int Id { get; set; }
        public Guid PostId { set; get; }
        public Guid TagId { set; get; }

        [ForeignKey("PostId")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
