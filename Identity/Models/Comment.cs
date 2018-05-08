using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Models

{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [StringLength(255, ErrorMessage = "Please do not exceed 255 characters.")]
        public string Content { get; set; }

        public int UserId { get; set; }
        public int BlogPostId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual BlogPost BlogPost { get; set; }
    }
}


/*
        [Table("Comments")]
        public class Comment
        {
        [Key]
        public int CommentId { get; set; }

        [StringLength(255, ErrorMessage = "Please do not exceed 255 characters.")]
        public string Content { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        }



 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBearKingdom.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Author { get; set; }

        [StringLength(255, ErrorMessage = "Cut it down. The Review cannot exceed 255 characters.")]
        public string Content_Body { get; set; }

        [Range(1, 5, ErrorMessage = "Price must be between 1 and 5")]
        public int rating { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
     
     
     */
