using System.ComponentModel.DataAnnotations;

namespace TreeOfLife.Models
{
    public class TreeNode
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
